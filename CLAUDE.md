# Claude Code Instructions

## Data Access Rules

- **Never read files directly from `MCP.External/Data/`**. Always use the MCP tools (`mcp__local-mcp-server__*`) to query data.
- If an MCP tool does not exist for the required query, implement one first, then use it.
