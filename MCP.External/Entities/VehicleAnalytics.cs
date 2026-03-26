using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MCP.External.Entities
{
    public class VehicleAnalyticsResponse
    {
        [JsonPropertyName("summary")]
        public VehicleSummary Summary { get; set; }

        [JsonPropertyName("by_status")]
        public List<StatusStat> ByStatus { get; set; }

        [JsonPropertyName("by_vehicle_type")]
        public List<VehicleTypeStat> ByVehicleType { get; set; }

        [JsonPropertyName("by_make")]
        public List<MakeStat> ByMake { get; set; }

        [JsonPropertyName("by_year_bucket")]
        public List<LabelCountStat> ByYearBucket { get; set; }

        [JsonPropertyName("by_model_year")]
        public List<ModelYearStat> ByModelYear { get; set; }

        [JsonPropertyName("by_group")]
        public List<VehicleGroupStat> ByGroup { get; set; }

        [JsonPropertyName("by_state")]
        public List<StateStat> ByState { get; set; }

        [JsonPropertyName("by_hibernation")]
        public List<LabelCountStat> ByHibernation { get; set; }

        [JsonPropertyName("eld_dvir")]
        public EldDvirBreakdown EldDvir { get; set; }

        [JsonPropertyName("by_seat_belt")]
        public List<LabelCountStat> BySeatBelt { get; set; }

        [JsonPropertyName("by_inspection_list")]
        public List<LabelCountStat> ByInspectionList { get; set; }

        [JsonPropertyName("type_by_status")]
        public List<VehicleTypeByStatus> TypeByStatus { get; set; }

        [JsonPropertyName("by_checkin_month")]
        public List<CheckinMonthStat> ByCheckinMonth { get; set; }
    }

    public class VehicleSummary
    {
        [JsonPropertyName("total_vehicles")]
        public int TotalVehicles { get; set; }

        [JsonPropertyName("in_service")]
        public int InService { get; set; }

        [JsonPropertyName("out_of_service")]
        public int OutOfService { get; set; }

        [JsonPropertyName("spare")]
        public int Spare { get; set; }

        [JsonPropertyName("removed")]
        public int Removed { get; set; }

        [JsonPropertyName("pending_removal")]
        public int PendingRemoval { get; set; }

        [JsonPropertyName("unknown_status")]
        public int UnknownStatus { get; set; }

        [JsonPropertyName("eld_enabled")]
        public int EldEnabled { get; set; }

        [JsonPropertyName("dvir_enabled")]
        public int DvirEnabled { get; set; }

        [JsonPropertyName("has_check_in")]
        public int HasCheckIn { get; set; }

        [JsonPropertyName("never_checked_in")]
        public int NeverCheckedIn { get; set; }
    }

    public class StatusStat
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }
    }

    public class VehicleTypeStat
    {
        [JsonPropertyName("vehicle_type")]
        public string VehicleType { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("in_service")]
        public int InService { get; set; }

        [JsonPropertyName("out_of_service")]
        public int OutOfService { get; set; }
    }

    public class MakeStat
    {
        [JsonPropertyName("make")]
        public string Make { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("in_service")]
        public int InService { get; set; }
    }

    public class ModelYearStat
    {
        [JsonPropertyName("year")]
        public int Year { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("in_service")]
        public int InService { get; set; }
    }

    public class VehicleGroupStat
    {
        [JsonPropertyName("group")]
        public string Group { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("in_service")]
        public int InService { get; set; }

        [JsonPropertyName("out_of_service")]
        public int OutOfService { get; set; }

        [JsonPropertyName("eld_enabled")]
        public int EldEnabled { get; set; }

        [JsonPropertyName("dvir_enabled")]
        public int DvirEnabled { get; set; }
    }

    public class StateStat
    {
        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }
    }

    public class EldDvirBreakdown
    {
        [JsonPropertyName("eld")]
        public EnabledDisabledCount Eld { get; set; }

        [JsonPropertyName("dvir")]
        public EnabledDisabledCount Dvir { get; set; }
    }

    public class EnabledDisabledCount
    {
        [JsonPropertyName("Enabled")]
        public int Enabled { get; set; }

        [JsonPropertyName("Disabled")]
        public int Disabled { get; set; }
    }

    public class VehicleTypeByStatus
    {
        [JsonPropertyName("vehicle_type")]
        public string VehicleType { get; set; }

        [JsonPropertyName("In Service")]
        public int InService { get; set; }

        [JsonPropertyName("Out Of Service")]
        public int OutOfService { get; set; }

        [JsonPropertyName("Spare")]
        public int Spare { get; set; }

        [JsonPropertyName("Removed From Fleet")]
        public int RemovedFromFleet { get; set; }

        [JsonPropertyName("Pending Removal From Fleet")]
        public int PendingRemovalFromFleet { get; set; }

        [JsonPropertyName("Unknown")]
        public int Unknown { get; set; }
    }

    public class CheckinMonthStat
    {
        /// <summary>ISO label e.g. "2025-12"</summary>
        [JsonPropertyName("month_year")]
        public string MonthYear { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }
    }

    public class LabelCountStat
    {
        // One of these will be populated depending on the list:
        [JsonPropertyName("year_bucket")]
        public string YearBucket { get; set; }

        [JsonPropertyName("hibernation")]
        public string Hibernation { get; set; }

        [JsonPropertyName("seat_belt_type")]
        public string SeatBeltType { get; set; }

        [JsonPropertyName("inspection_list")]
        public string InspectionList { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }
    }
}

