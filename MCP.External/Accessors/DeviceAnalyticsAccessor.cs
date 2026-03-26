using MCP.External.Data;
using MCP.External.Entities;
using ModelContextProtocol.Server;
using System.ComponentModel;
using System.Text.Json;

namespace MCP.External.Accessors
{
    [McpServerToolType]
    internal class DeviceAnalyticsAccessor
    {
        #region Private Methods

        private async Task<DeviceAnalyticsResponse> GetDeviceAnalytics()
        {
            using var stream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(DeviceAnalyticsStaticResource.DeviceAnalyticsJson));
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            return await JsonSerializer.DeserializeAsync<DeviceAnalyticsResponse>(stream, options)
                ?? new DeviceAnalyticsResponse();
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

        [McpServerTool, Description("Get full device analytics including summary, device types, health, status, and group breakdowns")]
        public async Task<string> GetDeviceAnalytics_All()
        {
            return await SerializeAsync(await GetDeviceAnalytics());
        }

        [McpServerTool, Description("Get device analytics summary (total devices, in-service, health, RMA, asset counts)")]
        public async Task<string> GetDeviceAnalytics_Summary()
        {
            var data = await GetDeviceAnalytics();
            return await SerializeAsync(data.Summary);
        }

        [McpServerTool, Description("Get device counts broken down by group")]
        public async Task<string> GetDeviceAnalytics_ByGroup()
        {
            var data = await GetDeviceAnalytics();
            return await SerializeAsync(data.ByGroup);
        }

        [McpServerTool, Description("Get device counts broken down by device type")]
        public async Task<string> GetDeviceAnalytics_ByDeviceType()
        {
            var data = await GetDeviceAnalytics();
            return await SerializeAsync(data.ByDeviceType);
        }

        [McpServerTool, Description("Get device health issues detail")]
        public async Task<string> GetDeviceAnalytics_HealthIssues()
        {
            var data = await GetDeviceAnalytics();
            return await SerializeAsync(data.HealthIssuesDetail);
        }

        #endregion
    }
}
