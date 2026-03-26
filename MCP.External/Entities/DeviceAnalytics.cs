using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MCP.External.Entities
{
    // â”€â”€ Root â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€
    public class DeviceAnalyticsResponse
    {
        [JsonPropertyName("summary")]
        public DeviceSummary Summary { get; set; }

        [JsonPropertyName("by_device_type")]
        public List<DeviceTypeStat> ByDeviceType { get; set; }

        [JsonPropertyName("by_status")]
        public List<CountStat> ByStatus { get; set; }

        [JsonPropertyName("by_health")]
        public List<CountStat> ByHealth { get; set; }

        [JsonPropertyName("by_operating_state")]
        public List<CountStat> ByOperatingState { get; set; }

        [JsonPropertyName("by_group")]
        public List<GroupStat> ByGroup { get; set; }

        [JsonPropertyName("by_initial_year")]
        public List<InitialYearStat> ByInitialYear { get; set; }

        [JsonPropertyName("by_initial_month")]
        public List<InitialMonthStat> ByInitialMonth { get; set; }

        [JsonPropertyName("health_issues_detail")]
        public List<HealthIssueStat> HealthIssuesDetail { get; set; }

        [JsonPropertyName("comm_staleness")]
        public List<CountStat> CommStaleness { get; set; }

        /// <summary>Devices that have never communicated</summary>
        [JsonPropertyName("never_communicated")]
        public int NeverCommunicated { get; set; }

        [JsonPropertyName("status_by_device_type")]
        public List<StatusByDeviceType> StatusByDeviceType { get; set; }

        [JsonPropertyName("by_aux_cam_count")]
        public List<AuxCamStat> ByAuxCamCount { get; set; }
    }

    // â”€â”€ Summary â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€
    public class DeviceSummary
    {
        [JsonPropertyName("total_devices")]
        public int TotalDevices { get; set; }

        [JsonPropertyName("in_service")]
        public int InService { get; set; }

        [JsonPropertyName("out_of_service")]
        public int OutOfService { get; set; }

        [JsonPropertyName("spare")]
        public int Spare { get; set; }

        [JsonPropertyName("open_rma")]
        public int OpenRma { get; set; }

        [JsonPropertyName("no_issues")]
        public int NoIssues { get; set; }

        [JsonPropertyName("with_issues")]
        public int WithIssues { get; set; }

        [JsonPropertyName("with_asset")]
        public int WithAsset { get; set; }

        [JsonPropertyName("without_asset")]
        public int WithoutAsset { get; set; }

        [JsonPropertyName("with_hub")]
        public int WithHub { get; set; }

        [JsonPropertyName("with_aux_cams")]
        public int WithAuxCams { get; set; }

        [JsonPropertyName("never_moved")]
        public int NeverMoved { get; set; }
    }

    // â”€â”€ Reusable generic stat â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€
    // Used by: by_status, by_health, by_operating_state, comm_staleness
    public class CountStat
    {
        // Each list uses a different label key ("status", "health",
        // "operating_state", "bucket") â€” all deserialized via this generic class.
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("health")]
        public string Health { get; set; }

        [JsonPropertyName("operating_state")]
        public string OperatingState { get; set; }

        [JsonPropertyName("bucket")]
        public string Bucket { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }
    }

    // â”€â”€ by_device_type â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€
    public class DeviceTypeStat
    {
        [JsonPropertyName("device_type")]
        public string DeviceType { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("in_service")]
        public int InService { get; set; }

        [JsonPropertyName("out_of_service")]
        public int OutOfService { get; set; }

        [JsonPropertyName("no_issues")]
        public int NoIssues { get; set; }

        [JsonPropertyName("with_issues")]
        public int WithIssues { get; set; }
    }

    // â”€â”€ by_group â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€
    public class GroupStat
    {
        [JsonPropertyName("group")]
        public string Group { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("in_service")]
        public int InService { get; set; }

        [JsonPropertyName("no_issues")]
        public int NoIssues { get; set; }

        [JsonPropertyName("with_issues")]
        public int WithIssues { get; set; }
    }

    // â”€â”€ by_initial_year â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€
    public class InitialYearStat
    {
        [JsonPropertyName("year")]
        public int Year { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("in_service")]
        public int InService { get; set; }
    }

    // â”€â”€ by_initial_month â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€
    public class InitialMonthStat
    {
        /// <summary>ISO-style label e.g. "2025-03"</summary>
        [JsonPropertyName("month_year")]
        public string MonthYear { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("in_service")]
        public int InService { get; set; }
    }

    // â”€â”€ health_issues_detail â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€
    public class HealthIssueStat
    {
        [JsonPropertyName("issue")]
        public string Issue { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }
    }

    // â”€â”€ status_by_device_type â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€
    public class StatusByDeviceType
    {
        [JsonPropertyName("device_type")]
        public string DeviceType { get; set; }

        [JsonPropertyName("In Service")]
        public int InService { get; set; }

        [JsonPropertyName("Out Of Service - Unattached")]
        public int OutOfServiceUnattached { get; set; }

        [JsonPropertyName("Out Of Service - Attached")]
        public int OutOfServiceAttached { get; set; }

        [JsonPropertyName("Spare")]
        public int Spare { get; set; }

        [JsonPropertyName("Open RMA")]
        public int OpenRma { get; set; }
    }

    // â”€â”€ by_aux_cam_count â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€
    public class AuxCamStat
    {
        [JsonPropertyName("cam_count")]
        public int CamCount { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }
    }
}

