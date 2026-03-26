using MCP.External.Data;
using MCP.External.Entities;
using ModelContextProtocol.Server;
using System.ComponentModel;
using System.Text.Json;

namespace MCP.External.Accessors
{
    [McpServerToolType]
    internal class RecognitionHistoryAccessor
    {
        #region Private Methods

        private async Task<List<PositiveRecognition>> GetRecognitionHistory()
        {
            using var stream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(RecognitionHistoryStaticResource.RecognitionHistoryJson));
            var jsonDoc = await JsonDocument.ParseAsync(stream);
            var recognitionHistoryElement = jsonDoc.RootElement.GetProperty("recognitionHistory");
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var recognitionHistory = JsonSerializer.Deserialize<List<PositiveRecognition>>(recognitionHistoryElement.GetRawText(), options);
            return recognitionHistory ?? new List<PositiveRecognition>();
        }

        private async Task<string> GetRecognitionHistoryAsString(List<PositiveRecognition>? recognitionHistory)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            var recognitionHistoryToSerialize = recognitionHistory ?? new List<PositiveRecognition>();
            using var stream = new MemoryStream();
            await JsonSerializer.SerializeAsync(stream, recognitionHistoryToSerialize, options);
            stream.Position = 0;
            using var reader = new StreamReader(stream);
            return await reader.ReadToEndAsync();
        }

        #endregion

        #region Public Methods

        [McpServerTool, Description("Get all Recognition History")]
        public async Task<string> GetAllRecognitionHistory()
        {
            return await GetRecognitionHistoryAsString(await GetRecognitionHistory());
        }

        [McpServerTool, Description("Get Recognition History by driver or issued by")]
        public async Task<string> GetRecognitionHistoryByUser(string user)
        {
            var recognitionHistory = await GetRecognitionHistory();
            var filteredRecognitionHistory = recognitionHistory.Where(recognition =>
                recognition.Driver != null && recognition.Driver.Equals(user, StringComparison.OrdinalIgnoreCase)
                || recognition.IssuedBy != null && recognition.IssuedBy.Equals(user, StringComparison.OrdinalIgnoreCase)
            ).ToList();

            return await GetRecognitionHistoryAsString(filteredRecognitionHistory);
        }

        [McpServerTool, Description("Get Recognition History by type")]
        public async Task<string> GetRecognitionHistoryByType(string type)
        {
            var recognitionHistory = await GetRecognitionHistory();
            var filteredRecognitionHistory = recognitionHistory.Where(recognition =>
                recognition.Type != null && recognition.Type.Equals(type, StringComparison.OrdinalIgnoreCase)
            ).ToList();

            return await GetRecognitionHistoryAsString(filteredRecognitionHistory);
        }

        [McpServerTool, Description("Get Recognition History by group")]
        public async Task<string> GetRecognitionHistoryByGroup(string group)
        {
            var recognitionHistory = await GetRecognitionHistory();
            var filteredRecognitionHistory = recognitionHistory.Where(recognition =>
                recognition.Group != null && recognition.Group.Contains(group, StringComparison.OrdinalIgnoreCase)
            ).ToList();

            return await GetRecognitionHistoryAsString(filteredRecognitionHistory);
        }

        [McpServerTool, Description("Get Recognition History by event ID")]
        public async Task<string> GetRecognitionHistoryByEventId(string eventId)
        {
            var recognitionHistory = await GetRecognitionHistory();
            var filteredRecognitionHistory = recognitionHistory.Where(recognition =>
                recognition.EventId != null && recognition.EventId.Equals(eventId, StringComparison.OrdinalIgnoreCase)
            ).ToList();

            return await GetRecognitionHistoryAsString(filteredRecognitionHistory);
        }

        [McpServerTool, Description("Get Recognition History by issued date")]
        public async Task<string> GetRecognitionHistoryByDate(string issuedDate)
        {
            var recognitionHistory = await GetRecognitionHistory();
            var filteredRecognitionHistory = recognitionHistory.Where(recognition =>
                recognition.IssuedDate != null && recognition.IssuedDate.Equals(issuedDate, StringComparison.OrdinalIgnoreCase)
            ).ToList();

            return await GetRecognitionHistoryAsString(filteredRecognitionHistory);
        }

        [McpServerTool, Description("Search Recognition History by keyword in recognition reason")]
        public async Task<string> SearchRecognitionHistoryByReason(string keyword)
        {
            var recognitionHistory = await GetRecognitionHistory();
            var filteredRecognitionHistory = recognitionHistory.Where(recognition =>
                recognition.RecognitionReason != null && recognition.RecognitionReason.Contains(keyword, StringComparison.OrdinalIgnoreCase)
            ).ToList();

            return await GetRecognitionHistoryAsString(filteredRecognitionHistory);
        }

        [McpServerTool, Description("Get Recognition History by driver name only")]
        public async Task<string> GetRecognitionHistoryByDriver(string driver)
        {
            var recognitionHistory = await GetRecognitionHistory();
            var filtered = recognitionHistory.Where(r =>
                r.Driver != null && r.Driver.Contains(driver, StringComparison.OrdinalIgnoreCase)
            ).ToList();

            return await GetRecognitionHistoryAsString(filtered);
        }

        [McpServerTool, Description("Get Recognition History by the person who issued the recognition")]
        public async Task<string> GetRecognitionHistoryByIssuedBy(string issuedBy)
        {
            var recognitionHistory = await GetRecognitionHistory();
            var filtered = recognitionHistory.Where(r =>
                r.IssuedBy != null && r.IssuedBy.Contains(issuedBy, StringComparison.OrdinalIgnoreCase)
            ).ToList();

            return await GetRecognitionHistoryAsString(filtered);
        }

        [McpServerTool, Description("Get Recognition History issued within a date range. Dates must be in format 'MMM dd, yyyy' e.g. 'Jan 01, 2025'")]
        public async Task<string> GetRecognitionHistoryByDateRange(string fromDate, string toDate)
        {
            var recognitionHistory = await GetRecognitionHistory();
            var formats = new[] { "MMM dd, yyyy", "MMM d, yyyy" };
            var culture = System.Globalization.CultureInfo.InvariantCulture;

            if (!DateTime.TryParseExact(fromDate, formats, culture, System.Globalization.DateTimeStyles.None, out var from) ||
                !DateTime.TryParseExact(toDate, formats, culture, System.Globalization.DateTimeStyles.None, out var to))
            {
                return "Invalid date format. Use 'MMM dd, yyyy' e.g. 'Jan 01, 2025'.";
            }

            var filtered = recognitionHistory.Where(r =>
                r.IssuedDate != null &&
                DateTime.TryParseExact(r.IssuedDate, formats, culture, System.Globalization.DateTimeStyles.None, out var d) &&
                d >= from && d <= to
            ).ToList();

            return await GetRecognitionHistoryAsString(filtered);
        }

        [McpServerTool, Description("Get Recognition History by month and year e.g. month=3 year=2026 for March 2026")]
        public async Task<string> GetRecognitionHistoryByMonth(int month, int year)
        {
            var recognitionHistory = await GetRecognitionHistory();
            var formats = new[] { "MMM dd, yyyy", "MMM d, yyyy" };
            var culture = System.Globalization.CultureInfo.InvariantCulture;

            var filtered = recognitionHistory.Where(r =>
                r.IssuedDate != null &&
                DateTime.TryParseExact(r.IssuedDate, formats, culture, System.Globalization.DateTimeStyles.None, out var d) &&
                d.Month == month && d.Year == year
            ).ToList();

            return await GetRecognitionHistoryAsString(filtered);
        }

        [McpServerTool, Description("Get Recognition History records that are missing a group assignment")]
        public async Task<string> GetRecognitionHistoryWithMissingGroup()
        {
            var recognitionHistory = await GetRecognitionHistory();
            var filtered = recognitionHistory.Where(r =>
                string.IsNullOrWhiteSpace(r.Group)
            ).ToList();

            return await GetRecognitionHistoryAsString(filtered);
        }

        [McpServerTool, Description("Get a summary of Recognition History including counts by type, top groups, and top issuers")]
        public async Task<string> GetRecognitionHistorySummary()
        {
            var recognitionHistory = await GetRecognitionHistory();

            var summary = new
            {
                TotalRecognitions = recognitionHistory.Count,
                ByType = recognitionHistory
                    .GroupBy(r => r.Type ?? "Unknown")
                    .Select(g => new { Type = g.Key, Count = g.Count() })
                    .OrderByDescending(x => x.Count),
                TopGroups = recognitionHistory
                    .Where(r => !string.IsNullOrWhiteSpace(r.Group))
                    .GroupBy(r => r.Group!)
                    .Select(g => new { Group = g.Key, Count = g.Count() })
                    .OrderByDescending(x => x.Count)
                    .Take(10),
                TopIssuers = recognitionHistory
                    .Where(r => !string.IsNullOrWhiteSpace(r.IssuedBy))
                    .GroupBy(r => r.IssuedBy!)
                    .Select(g => new { IssuedBy = g.Key, Count = g.Count() })
                    .OrderByDescending(x => x.Count)
                    .Take(10),
                MissingGroupCount = recognitionHistory.Count(r => string.IsNullOrWhiteSpace(r.Group))
            };

            var options = new JsonSerializerOptions { WriteIndented = true };
            return JsonSerializer.Serialize(summary, options);
        }

        #endregion
    }
}
