using MCP.External.Data;
using MCP.External.Entities;
using ModelContextProtocol.Server;
using System.ComponentModel;
using System.Text.Json;

namespace MCP.External.Accessors
{
    [McpServerToolType]
    internal class CoachingHistoryAccessor
    {
        #region Private Methods

        private async Task<List<CoachingHistory>> GetCoachingHistory()
        {
            using var stream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(CoachingHistoryStaticResource.CoachingHistory));
            var jsonDoc = await JsonDocument.ParseAsync(stream);
            var historyElement = jsonDoc.RootElement.GetProperty("coachingHistory");
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var history = JsonSerializer.Deserialize<List<CoachingHistory>>(historyElement.GetRawText(), options);
            return history ?? new List<CoachingHistory>();
        }

        private async Task<string> GetCoachingHistoryAsString(List<CoachingHistory>? history)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            var toSerialize = history ?? new List<CoachingHistory>();
            using var stream = new MemoryStream();
            await JsonSerializer.SerializeAsync(stream, toSerialize, options);
            stream.Position = 0;
            using var reader = new StreamReader(stream);
            return await reader.ReadToEndAsync();
        }

        #endregion

        #region Public Methods

        [McpServerTool, Description("Get all coaching history records")]
        public async Task<string> GetAllCoachingHistory()
        {
            return await GetCoachingHistoryAsString(await GetCoachingHistory());
        }

        [McpServerTool, Description("Get coaching history records by driver name")]
        public async Task<string> GetCoachingHistoryByDriver(string driverName)
        {
            var history = await GetCoachingHistory();
            var filtered = history.Where(h =>
                h.Driver != null && h.Driver.Contains(driverName, StringComparison.OrdinalIgnoreCase)
            ).ToList();
            return await GetCoachingHistoryAsString(filtered);
        }

        [McpServerTool, Description("Get coaching history records by coach name")]
        public async Task<string> GetCoachingHistoryByCoach(string coachName)
        {
            var history = await GetCoachingHistory();
            var filtered = history.Where(h =>
                h.Coach != null && h.Coach.Contains(coachName, StringComparison.OrdinalIgnoreCase)
            ).ToList();
            return await GetCoachingHistoryAsString(filtered);
        }

        [McpServerTool, Description("Get coaching history records by behavior coached (e.g. 'Following Distance', 'Seatbelt', 'Smoking')")]
        public async Task<string> GetCoachingHistoryByBehavior(string behavior)
        {
            var history = await GetCoachingHistory();
            var filtered = history.Where(h =>
                h.BehaviorsCoached != null && h.BehaviorsCoached.Contains(behavior, StringComparison.OrdinalIgnoreCase)
            ).ToList();
            return await GetCoachingHistoryAsString(filtered);
        }

        [McpServerTool, Description("Get coaching history records by group or location (e.g. 'NFS - Pleasant Grove')")]
        public async Task<string> GetCoachingHistoryByGroup(string group)
        {
            var history = await GetCoachingHistory();
            var filtered = history.Where(h =>
                h.Group != null && h.Group.Contains(group, StringComparison.OrdinalIgnoreCase)
            ).ToList();
            return await GetCoachingHistoryAsString(filtered);
        }

        #endregion
    }
}
