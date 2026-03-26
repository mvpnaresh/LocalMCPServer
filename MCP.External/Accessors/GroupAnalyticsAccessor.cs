using MCP.External.Data;
using MCP.External.Entities;
using ModelContextProtocol.Server;
using System.ComponentModel;
using System.Text.Json;

namespace MCP.External.Accessors
{
    [McpServerToolType]
    internal class GroupAnalyticsAccessor
    {
        #region Private Methods

        private async Task<GroupAnalyticsResponse> GetGroupAnalytics()
        {
            using var stream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(GroupAnalyticsStaticResource.GroupAnalyticsJson));
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            return await JsonSerializer.DeserializeAsync<GroupAnalyticsResponse>(stream, options)
                ?? new GroupAnalyticsResponse();
        }

        private async Task<string> SerializeAsync<T>(T data)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            using var stream = new MemoryStream();
            await JsonSerializer.SerializeAsync(stream, data, options);
            stream.Position = 0;
            using var reader = new StreamReader(stream);
            return await reader.ReadToEndAsync();
        }

        #endregion

        #region Public Methods

        [McpServerTool, Description("Get full group analytics including summary, yearly trends, quarterly stats, and top root groups")]
        public async Task<string> GetGroupAnalytics_All()
        {
            return await SerializeAsync(await GetGroupAnalytics());
        }

        [McpServerTool, Description("Get group analytics summary (total groups, active, deleted, date range, avg revision)")]
        public async Task<string> GetGroupAnalytics_Summary()
        {
            var data = await GetGroupAnalytics();
            return await SerializeAsync(data.Summary);
        }

        [McpServerTool, Description("Get group counts broken down by year")]
        public async Task<string> GetGroupAnalytics_ByYear()
        {
            var data = await GetGroupAnalytics();
            return await SerializeAsync(data.ByYear);
        }

        [McpServerTool, Description("Get top root groups by total group count")]
        public async Task<string> GetGroupAnalytics_TopRootGroups()
        {
            var data = await GetGroupAnalytics();
            return await SerializeAsync(data.TopRootGroups);
        }

        [McpServerTool, Description("Get the top 20 most revised groups")]
        public async Task<string> GetGroupAnalytics_MostRevised()
        {
            var data = await GetGroupAnalytics();
            return await SerializeAsync(data.Top20MostRevised);
        }

        [McpServerTool, Description("Get group counts for a specific month by name (e.g. 'June', 'Jan', 'March'). Returns per-year breakdown and total for that month across all years.")]
        public async Task<string> GetGroupAnalytics_ByMonth(string monthName)
        {
            var data = await GetGroupAnalytics();

            var shortName = monthName.Length >= 3 ? monthName.Substring(0, 3) : monthName;
            shortName = char.ToUpper(shortName[0]) + shortName.Substring(1).ToLower();

            var matchingMonths = data.ByMonthAllTime?
                .Where(m => m.MonthName != null &&
                            m.MonthName.Equals(shortName, StringComparison.OrdinalIgnoreCase))
                .ToList() ?? new List<MonthStat>();

            var result = new
            {
                month = shortName,
                total_groups = matchingMonths.Sum(m => m.Total),
                total_active = matchingMonths.Sum(m => m.Active),
                total_deleted = matchingMonths.Sum(m => m.Deleted),
                by_year = matchingMonths
            };

            return await SerializeAsync(result);
        }

        #endregion
    }
}
