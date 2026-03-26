using MCP.External.Data;
using MCP.External.Entities;
using ModelContextProtocol.Server;
using System.ComponentModel;
using System.Text.Json;

namespace MCP.External.Accessors
{
    [McpServerToolType]
    internal class VehicleAnalyticsAccessor
    {
        #region Private Methods

        private async Task<VehicleAnalyticsResponse> GetVehicleAnalytics()
        {
            using var stream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(VehicleAnalyticsStaticResource.VehicleAnalyticsJson));
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            return await JsonSerializer.DeserializeAsync<VehicleAnalyticsResponse>(stream, options)
                ?? new VehicleAnalyticsResponse();
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

        [McpServerTool, Description("Get full vehicle analytics including summary, status breakdown, vehicle types, makes, and group stats")]
        public async Task<string> GetVehicleAnalytics_All()
        {
            return await SerializeAsync(await GetVehicleAnalytics());
        }

        [McpServerTool, Description("Get vehicle analytics summary (total vehicles, in-service, out-of-service, ELD/DVIR counts)")]
        public async Task<string> GetVehicleAnalytics_Summary()
        {
            var data = await GetVehicleAnalytics();
            return await SerializeAsync(data.Summary);
        }

        [McpServerTool, Description("Get vehicle counts broken down by group")]
        public async Task<string> GetVehicleAnalytics_ByGroup()
        {
            var data = await GetVehicleAnalytics();
            return await SerializeAsync(data.ByGroup);
        }

        [McpServerTool, Description("Get vehicle counts broken down by status (In Service, Out of Service, Spare, etc.)")]
        public async Task<string> GetVehicleAnalytics_ByStatus()
        {
            var data = await GetVehicleAnalytics();
            return await SerializeAsync(data.ByStatus);
        }

        [McpServerTool, Description("Get vehicle counts broken down by vehicle type")]
        public async Task<string> GetVehicleAnalytics_ByVehicleType()
        {
            var data = await GetVehicleAnalytics();
            return await SerializeAsync(data.ByVehicleType);
        }

        #endregion
    }
}
