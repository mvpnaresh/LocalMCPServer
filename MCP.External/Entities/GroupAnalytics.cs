using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MCP.External.Entities
{
    public class GroupAnalyticsResponse
    {
        [JsonPropertyName("summary")]
        public Summary Summary { get; set; }

        [JsonPropertyName("by_year")]
        public List<YearStat> ByYear { get; set; }

        [JsonPropertyName("by_month_all_time")]
        public List<MonthStat> ByMonthAllTime { get; set; }

        [JsonPropertyName("monthly_per_year")]
        public Dictionary<string, Dictionary<string, int>> MonthlyPerYear { get; set; }

        [JsonPropertyName("by_quarter")]
        public List<QuarterStat> ByQuarter { get; set; }

        [JsonPropertyName("status_breakdown")]
        public Dictionary<string, int> StatusBreakdown { get; set; }

        [JsonPropertyName("top_root_groups")]
        public List<RootGroupStat> TopRootGroups { get; set; }

        [JsonPropertyName("hierarchy_depth_distribution")]
        public List<DepthStat> HierarchyDepthDistribution { get; set; }

        [JsonPropertyName("by_day_of_week")]
        public List<DayOfWeekStat> ByDayOfWeek { get; set; }

        [JsonPropertyName("top_20_most_revised")]
        public List<RevisedGroup> Top20MostRevised { get; set; }

        [JsonPropertyName("revision_bucket_distribution")]
        public List<RevisionBucket> RevisionBucketDistribution { get; set; }

        [JsonPropertyName("deleted_by_year")]
        public List<DeletedByYear> DeletedByYear { get; set; }

        [JsonPropertyName("root_group_growth_top5")]
        public Dictionary<string, Dictionary<string, int>> RootGroupGrowthTop5 { get; set; }
    }

    public class Summary
    {
        [JsonPropertyName("total_groups")]
        public int TotalGroups { get; set; }

        [JsonPropertyName("active")]
        public int Active { get; set; }

        [JsonPropertyName("deleted")]
        public int Deleted { get; set; }

        [JsonPropertyName("date_range")]
        public DateRange DateRange { get; set; }

        [JsonPropertyName("total_years")]
        public int TotalYears { get; set; }

        [JsonPropertyName("total_root_groups")]
        public int TotalRootGroups { get; set; }

        [JsonPropertyName("avg_revision")]
        public double AvgRevision { get; set; }

        [JsonPropertyName("max_revision")]
        public int MaxRevision { get; set; }

        [JsonPropertyName("avg_hierarchy_depth")]
        public double AvgHierarchyDepth { get; set; }
    }

    public class DateRange
    {
        [JsonPropertyName("from")]
        public string From { get; set; }

        [JsonPropertyName("to")]
        public string To { get; set; }
    }

    public class YearStat
    {
        [JsonPropertyName("year")]
        public int Year { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("active")]
        public int Active { get; set; }

        [JsonPropertyName("deleted")]
        public int Deleted { get; set; }

        [JsonPropertyName("avg_revision")]
        public double AvgRevision { get; set; }
    }

    public class MonthStat
    {
        [JsonPropertyName("year")]
        public int Year { get; set; }

        [JsonPropertyName("month")]
        public int Month { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("active")]
        public int Active { get; set; }

        [JsonPropertyName("deleted")]
        public int Deleted { get; set; }

        [JsonPropertyName("month_name")]
        public string MonthName { get; set; }

        [JsonPropertyName("month_year")]
        public string MonthYear { get; set; }
    }

    public class QuarterStat
    {
        [JsonPropertyName("year")]
        public int Year { get; set; }

        [JsonPropertyName("quarter")]
        public int Quarter { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("active")]
        public int Active { get; set; }

        [JsonPropertyName("deleted")]
        public int Deleted { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }
    }

    public class RootGroupStat
    {
        [JsonPropertyName("root_group")]
        public string RootGroup { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("active")]
        public int Active { get; set; }

        [JsonPropertyName("deleted")]
        public int Deleted { get; set; }

        [JsonPropertyName("avg_revision")]
        public double AvgRevision { get; set; }
    }

    public class DepthStat
    {
        [JsonPropertyName("depth")]
        public int Depth { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }
    }

    public class DayOfWeekStat
    {
        [JsonPropertyName("day")]
        public string Day { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }
    }

    public class RevisedGroup
    {
        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("Revision")]
        public int Revision { get; set; }

        [JsonPropertyName("root_group")]
        public string RootGroup { get; set; }

        [JsonPropertyName("year")]
        public int Year { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }
    }

    public class RevisionBucket
    {
        [JsonPropertyName("bucket")]
        public string Bucket { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }
    }

    public class DeletedByYear
    {
        [JsonPropertyName("year")]
        public int Year { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }
    }
}

