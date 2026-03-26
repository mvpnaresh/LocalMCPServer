using System.Text.Json;
using Anthropic;
using Anthropic.Models.Messages;
using ModelContextProtocol.Client;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(opts =>
    opts.AddDefaultPolicy(p => p.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));

var app = builder.Build();
app.UseCors();
app.UseDefaultFiles();
app.UseStaticFiles();

const string McpServerUrl = "http://mcp-alb-241104355.us-east-1.elb.amazonaws.com/sse";

const string SystemPrompt =
    "You are a helpful assistant with access to three tools: " +
    "weather (get current weather for any city), " +
    "books (browse a catalog of books by category), and " +
    "coaching sessions (look up driver coaching sessions by coach, driver, or date). " +
    "Use these tools proactively whenever they can help answer the user's question. " +
    "Always be concise and friendly.";

app.MapPost("/api/chat", async (ChatRequest req, ILoggerFactory loggerFactory) =>
{
    var apiKey = Environment.GetEnvironmentVariable("ANTHROPIC_API_KEY")
        ?? throw new InvalidOperationException("ANTHROPIC_API_KEY environment variable is not set.");

    var anthropic = new AnthropicClient { ApiKey = apiKey };

    // Connect to the deployed MCP server
    var transport = new SseClientTransport(
        new SseClientTransportOptions { Endpoint = new Uri(McpServerUrl) },
        loggerFactory);

    await using var mcp = await McpClientFactory.CreateAsync(
        transport,
        new McpClientOptions { ClientInfo = new() { Name = "ChatApp", Version = "1.0.0" } },
        loggerFactory);

    // Fetch all tools from the MCP server
    var mcpTools = await mcp.ListToolsAsync();

    // Convert MCP tools → Anthropic Tool format
    var anthropicTools = mcpTools.Select(t =>
    {
        var props = new Dictionary<string, JsonElement>();
        var required = new List<string>();

        if (t.JsonSchema.ValueKind == JsonValueKind.Object)
        {
            if (t.JsonSchema.TryGetProperty("properties", out var propsEl) &&
                propsEl.ValueKind == JsonValueKind.Object)
            {
                foreach (var prop in propsEl.EnumerateObject())
                    props[prop.Name] = prop.Value.Clone();
            }
            if (t.JsonSchema.TryGetProperty("required", out var reqEl) &&
                reqEl.ValueKind == JsonValueKind.Array)
            {
                required = reqEl.EnumerateArray()
                    .Select(r => r.GetString() ?? string.Empty)
                    .Where(s => s.Length > 0)
                    .ToList();
            }
        }

        return new Tool
        {
            Name = t.Name,
            Description = t.Description ?? t.Name,
            InputSchema = new() { Properties = props, Required = required }
        };
    }).ToList();

    // Build message history from the request
    var messages = req.Messages
        .Select(m => new MessageParam
        {
            Role = m.Role == "user" ? Role.User : Role.Assistant,
            Content = m.Content
        })
        .ToList();

    var toolCallLog = new List<ToolCallEntry>();
    string finalText = string.Empty;

    // Agentic tool loop — keep going until Claude stops requesting tools
    while (true)
    {
        var response = await anthropic.Messages.Create(new MessageCreateParams
        {
            Model = Model.ClaudeOpus4_6,
            MaxTokens = 4096,
            System = SystemPrompt,
            Tools = anthropicTools.Select(t => (ToolUnion)t).ToList(),
            Messages = messages
        });

        var assistantBlocks = new List<ContentBlockParam>();
        var toolResultBlocks = new List<ContentBlockParam>();

        foreach (var block in response.Content)
        {
            if (block.TryPickText(out var textBlock))
            {
                assistantBlocks.Add(new TextBlockParam { Text = textBlock.Text });
                finalText = textBlock.Text;
            }
            else if (block.TryPickToolUse(out var toolUse))
            {
                assistantBlocks.Add(new ToolUseBlockParam
                {
                    ID = toolUse.ID,
                    Name = toolUse.Name,
                    Input = toolUse.Input
                });

                // Convert Anthropic JsonElement args → MCP object args
                var args = new Dictionary<string, object>(
                    toolUse.Input.Select(kvp =>
                        new KeyValuePair<string, object>(kvp.Key, kvp.Value)));

                string toolResult;
                try
                {
                    var callResult = await mcp.CallToolAsync(toolUse.Name, args);
                    toolResult = callResult.IsError == true
                        ? $"Tool returned an error."
                        : string.Join("\n", callResult.Content
                            .Where(c => c.Type == "text")
                            .Select(c => (c as ModelContextProtocol.Protocol.TextContentBlock)?.Text ?? string.Empty));
                }
                catch (Exception ex)
                {
                    toolResult = $"Error calling {toolUse.Name}: {ex.Message}";
                }

                // Record for the UI
                toolCallLog.Add(new ToolCallEntry(
                    Tool: toolUse.Name,
                    Input: toolUse.Input.ToString(),
                    Output: toolResult));

                toolResultBlocks.Add(new ToolResultBlockParam
                {
                    ToolUseID = toolUse.ID,
                    Content = toolResult
                });
            }
        }

        // Stop if Claude is done or made no tool calls
        if (response.StopReason != StopReason.ToolUse || toolResultBlocks.Count == 0)
            break;

        // Feed results back and continue
        messages.Add(new MessageParam { Role = Role.Assistant, Content = assistantBlocks });
        messages.Add(new MessageParam { Role = Role.User, Content = toolResultBlocks });
    }

    return Results.Ok(new ChatResponse(finalText, toolCallLog));
});

// Endpoint to list available tools (used by the UI sidebar)
app.MapGet("/api/tools", async (ILoggerFactory loggerFactory) =>
{
    var transport = new SseClientTransport(
        new SseClientTransportOptions { Endpoint = new Uri(McpServerUrl) },
        loggerFactory);

    await using var mcp = await McpClientFactory.CreateAsync(
        transport,
        new McpClientOptions { ClientInfo = new() { Name = "ChatApp", Version = "1.0.0" } },
        loggerFactory);

    var tools = await mcp.ListToolsAsync();
    return Results.Ok(tools.Select(t => new { t.Name, t.Description }));
});

await app.RunAsync();

// ── Request / response models ─────────────────────────────────────────────────
record ChatMessage(string Role, string Content);
record ChatRequest(IReadOnlyList<ChatMessage> Messages);
record ToolCallEntry(string Tool, string Input, string Output);
record ChatResponse(string Response, IReadOnlyList<ToolCallEntry> ToolCalls);
