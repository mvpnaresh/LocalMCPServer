using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCP.External.Data
{
    internal static class DeviceAnalyticsStaticResource
    {
        internal static readonly string DeviceAnalyticsJson = @"{

        
  ""summary"": {
    ""total_devices"": 1758,
    ""in_service"": 611,
    ""out_of_service"": 1105,
    ""spare"": 36,
    ""open_rma"": 6,
    ""no_issues"": 1182,
    ""with_issues"": 576,
    ""with_asset"": 623,
    ""without_asset"": 1135,
    ""with_hub"": 10,
    ""with_aux_cams"": 11,
    ""never_moved"": 1646
  },
  ""by_device_type"": [
    {
      ""device_type"": ""SV2"",
      ""total"": 465,
      ""in_service"": 22,
      ""out_of_service"": 442,
      ""no_issues"": 444,
      ""with_issues"": 21
    },
    {
      ""device_type"": ""DC3"",
      ""total"": 301,
      ""in_service"": 180,
      ""out_of_service"": 109,
      ""no_issues"": 122,
      ""with_issues"": 179
    },
    {
      ""device_type"": ""DC3P"",
      ""total"": 216,
      ""in_service"": 180,
      ""out_of_service"": 36,
      ""no_issues"": 36,
      ""with_issues"": 180
    },
    {
      ""device_type"": ""SF1"",
      ""total"": 177,
      ""in_service"": 34,
      ""out_of_service"": 141,
      ""no_issues"": 144,
      ""with_issues"": 33
    },
    {
      ""device_type"": ""SF400"",
      ""total"": 132,
      ""in_service"": 76,
      ""out_of_service"": 41,
      ""no_issues"": 58,
      ""with_issues"": 74
    },
    {
      ""device_type"": ""SF300"",
      ""total"": 128,
      ""in_service"": 60,
      ""out_of_service"": 66,
      ""no_issues"": 91,
      ""with_issues"": 37
    },
    {
      ""device_type"": ""SF64"",
      ""total"": 86,
      ""in_service"": 14,
      ""out_of_service"": 68,
      ""no_issues"": 71,
      ""with_issues"": 15
    },
    {
      ""device_type"": ""Other"",
      ""total"": 74,
      ""in_service"": 5,
      ""out_of_service"": 68,
      ""no_issues"": 69,
      ""with_issues"": 5
    },
    {
      ""device_type"": ""DC2"",
      ""total"": 60,
      ""in_service"": 4,
      ""out_of_service"": 52,
      ""no_issues"": 56,
      ""with_issues"": 4
    },
    {
      ""device_type"": ""Unknown"",
      ""total"": 38,
      ""in_service"": 2,
      ""out_of_service"": 36,
      ""no_issues"": 36,
      ""with_issues"": 2
    },
    {
      ""device_type"": ""SF300V2"",
      ""total"": 19,
      ""in_service"": 11,
      ""out_of_service"": 7,
      ""no_issues"": 9,
      ""with_issues"": 10
    },
    {
      ""device_type"": ""SF300W"",
      ""total"": 19,
      ""in_service"": 4,
      ""out_of_service"": 15,
      ""no_issues"": 15,
      ""with_issues"": 4
    },
    {
      ""device_type"": ""SF500"",
      ""total"": 12,
      ""in_service"": 6,
      ""out_of_service"": 6,
      ""no_issues"": 4,
      ""with_issues"": 8
    },
    {
      ""device_type"": ""GO9"",
      ""total"": 9,
      ""in_service"": 5,
      ""out_of_service"": 4,
      ""no_issues"": 9,
      ""with_issues"": 0
    },
    {
      ""device_type"": ""SF200"",
      ""total"": 6,
      ""in_service"": 2,
      ""out_of_service"": 4,
      ""no_issues"": 4,
      ""with_issues"": 2
    },
    {
      ""device_type"": ""XT4500"",
      ""total"": 5,
      ""in_service"": 1,
      ""out_of_service"": 4,
      ""no_issues"": 5,
      ""with_issues"": 0
    },
    {
      ""device_type"": ""GoAnywhere"",
      ""total"": 5,
      ""in_service"": 2,
      ""out_of_service"": 3,
      ""no_issues"": 5,
      ""with_issues"": 0
    },
    {
      ""device_type"": ""3D"",
      ""total"": 1,
      ""in_service"": 1,
      ""out_of_service"": 0,
      ""no_issues"": 0,
      ""with_issues"": 1
    },
    {
      ""device_type"": ""AVM"",
      ""total"": 1,
      ""in_service"": 0,
      ""out_of_service"": 1,
      ""no_issues"": 1,
      ""with_issues"": 0
    },
    {
      ""device_type"": ""GO9B"",
      ""total"": 1,
      ""in_service"": 1,
      ""out_of_service"": 0,
      ""no_issues"": 1,
      ""with_issues"": 0
    },
    {
      ""device_type"": ""SF400V2"",
      ""total"": 1,
      ""in_service"": 1,
      ""out_of_service"": 0,
      ""no_issues"": 0,
      ""with_issues"": 1
    },
    {
      ""device_type"": ""hwplatformtestAPIabcd"",
      ""total"": 1,
      ""in_service"": 0,
      ""out_of_service"": 1,
      ""no_issues"": 1,
      ""with_issues"": 0
    },
    {
      ""device_type"": ""plat"",
      ""total"": 1,
      ""in_service"": 0,
      ""out_of_service"": 1,
      ""no_issues"": 1,
      ""with_issues"": 0
    }
  ],
  ""by_status"": [
    {
      ""status"": ""Out Of Service - Unattached"",
      ""count"": 1061
    },
    {
      ""status"": ""In Service"",
      ""count"": 611
    },
    {
      ""status"": ""Out Of Service - Attached"",
      ""count"": 44
    },
    {
      ""status"": ""Spare"",
      ""count"": 36
    },
    {
      ""status"": ""Open RMA"",
      ""count"": 6
    }
  ],
  ""by_health"": [
    {
      ""health"": ""No Issues"",
      ""count"": 1182
    },
    {
      ""health"": ""Overdue for Check-in"",
      ""count"": 544
    },
    {
      ""health"": ""Camera Issue"",
      ""count"": 10
    },
    {
      ""health"": ""Overdue for Check-in, Camera Issue"",
      ""count"": 4
    },
    {
      ""health"": ""Power Disconnects"",
      ""count"": 3
    },
    {
      ""health"": ""SD Card Issue"",
      ""count"": 3
    },
    {
      ""health"": ""Power Disconnects, Camera Issue"",
      ""count"": 2
    },
    {
      ""health"": ""Hub Issue"",
      ""count"": 2
    },
    {
      ""health"": ""Overdue for Check-in, Power Disconnects"",
      ""count"": 2
    },
    {
      ""health"": ""Camera Issue, Hub Issue"",
      ""count"": 1
    },
    {
      ""health"": ""Power Disconnects, Camera Issue, Hub Issue"",
      ""count"": 1
    },
    {
      ""health"": ""Overdue for Check-in, SD Card Issue"",
      ""count"": 1
    },
    {
      ""health"": ""Wrong Status, Camera Issue"",
      ""count"": 1
    },
    {
      ""health"": ""Overdue for Check-in, Power Disconnects, Camera Issue"",
      ""count"": 1
    },
    {
      ""health"": ""Overdue for Check-in, Hub Issue"",
      ""count"": 1
    }
  ],
  ""by_operating_state"": [
    {
      ""operating_state"": ""Deep Sleep"",
      ""count"": 1620
    },
    {
      ""operating_state"": ""Offline"",
      ""count"": 72
    },
    {
      ""operating_state"": ""Unknown"",
      ""count"": 48
    },
    {
      ""operating_state"": ""Active"",
      ""count"": 10
    },
    {
      ""operating_state"": ""Awake(Countdown)"",
      ""count"": 7
    },
    {
      ""operating_state"": ""Awake"",
      ""count"": 1
    }
  ],
  ""by_group"": [
    {
      ""group"": ""***Root0"",
      ""total"": 590,
      ""in_service"": 405,
      ""no_issues"": 208,
      ""with_issues"": 382
    },
    {
      ""group"": ""heidi long sub name--long group-long group-long111"",
      ""total"": 212,
      ""in_service"": 0,
      ""no_issues"": 212,
      ""with_issues"": 0
    },
    {
      ""group"": ""###DC4DC"",
      ""total"": 171,
      ""in_service"": 33,
      ""no_issues"": 143,
      ""with_issues"": 28
    },
    {
      ""group"": ""***BBacademy bus1"",
      ""total"": 68,
      ""in_service"": 9,
      ""no_issues"": 59,
      ""with_issues"": 9
    },
    {
      ""group"": ""Cellular Unassigned"",
      ""total"": 57,
      ""in_service"": 8,
      ""no_issues"": 45,
      ""with_issues"": 12
    },
    {
      ""group"": ""***Legacy"",
      ""total"": 51,
      ""in_service"": 0,
      ""no_issues"": 51,
      ""with_issues"": 0
    },
    {
      ""group"": ""heidi long name--long group-long group-long group-"",
      ""total"": 47,
      ""in_service"": 0,
      ""no_issues"": 47,
      ""with_issues"": 0
    },
    {
      ""group"": ""Lytx dev leader solution-RENAME"",
      ""total"": 35,
      ""in_service"": 0,
      ""no_issues"": 35,
      ""with_issues"": 0
    },
    {
      ""group"": ""***LC Flex"",
      ""total"": 33,
      ""in_service"": 0,
      ""no_issues"": 33,
      ""with_issues"": 0
    },
    {
      ""group"": ""***DBlack Test"",
      ""total"": 31,
      ""in_service"": 3,
      ""no_issues"": 28,
      ""with_issues"": 3
    },
    {
      ""group"": ""Default"",
      ""total"": 26,
      ""in_service"": 18,
      ""no_issues"": 10,
      ""with_issues"": 16
    },
    {
      ""group"": ""Dtest11 group name2"",
      ""total"": 24,
      ""in_service"": 5,
      ""no_issues"": 19,
      ""with_issues"": 5
    },
    {
      ""group"": ""***DC Updated 452756044"",
      ""total"": 19,
      ""in_service"": 0,
      ""no_issues"": 19,
      ""with_issues"": 0
    },
    {
      ""group"": ""***Root"",
      ""total"": 19,
      ""in_service"": 9,
      ""no_issues"": 10,
      ""with_issues"": 9
    },
    {
      ""group"": ""***CANADA Sim Test"",
      ""total"": 16,
      ""in_service"": 6,
      ""no_issues"": 10,
      ""with_issues"": 6
    },
    {
      ""group"": ""#LegacyUserTesting"",
      ""total"": 13,
      ""in_service"": 10,
      ""no_issues"": 4,
      ""with_issues"": 9
    },
    {
      ""group"": ""***Big Updated 2798182341"",
      ""total"": 13,
      ""in_service"": 3,
      ""no_issues"": 10,
      ""with_issues"": 3
    },
    {
      ""group"": ""*** BNSF MVAI Edited"",
      ""total"": 12,
      ""in_service"": 8,
      ""no_issues"": 4,
      ""with_issues"": 8
    },
    {
      ""group"": ""Flex Alpha Units"",
      ""total"": 12,
      ""in_service"": 1,
      ""no_issues"": 11,
      ""with_issues"": 1
    },
    {
      ""group"": ""***Cemex Columbia"",
      ""total"": 12,
      ""in_service"": 0,
      ""no_issues"": 12,
      ""with_issues"": 0
    }
  ],
  ""by_initial_year"": [
    {
      ""year"": 2006,
      ""total"": 11,
      ""in_service"": 2
    },
    {
      ""year"": 2007,
      ""total"": 174,
      ""in_service"": 68
    },
    {
      ""year"": 2008,
      ""total"": 60,
      ""in_service"": 37
    },
    {
      ""year"": 2009,
      ""total"": 28,
      ""in_service"": 21
    },
    {
      ""year"": 2010,
      ""total"": 24,
      ""in_service"": 13
    },
    {
      ""year"": 2011,
      ""total"": 29,
      ""in_service"": 22
    },
    {
      ""year"": 2012,
      ""total"": 61,
      ""in_service"": 42
    },
    {
      ""year"": 2013,
      ""total"": 25,
      ""in_service"": 22
    },
    {
      ""year"": 2014,
      ""total"": 42,
      ""in_service"": 39
    },
    {
      ""year"": 2015,
      ""total"": 345,
      ""in_service"": 50
    },
    {
      ""year"": 2016,
      ""total"": 281,
      ""in_service"": 40
    },
    {
      ""year"": 2017,
      ""total"": 159,
      ""in_service"": 49
    },
    {
      ""year"": 2018,
      ""total"": 71,
      ""in_service"": 13
    },
    {
      ""year"": 2019,
      ""total"": 34,
      ""in_service"": 4
    },
    {
      ""year"": 2020,
      ""total"": 80,
      ""in_service"": 18
    },
    {
      ""year"": 2021,
      ""total"": 26,
      ""in_service"": 5
    },
    {
      ""year"": 2022,
      ""total"": 22,
      ""in_service"": 7
    },
    {
      ""year"": 2023,
      ""total"": 40,
      ""in_service"": 19
    },
    {
      ""year"": 2024,
      ""total"": 135,
      ""in_service"": 88
    },
    {
      ""year"": 2025,
      ""total"": 81,
      ""in_service"": 37
    },
    {
      ""year"": 2026,
      ""total"": 15,
      ""in_service"": 7
    },
    {
      ""year"": 9999,
      ""total"": 1,
      ""in_service"": 0
    }
  ],
  ""by_initial_month"": [
    {
      ""month_year"": ""2024-01"",
      ""total"": 1,
      ""in_service"": 0
    },
    {
      ""month_year"": ""2024-02"",
      ""total"": 17,
      ""in_service"": 12
    },
    {
      ""month_year"": ""2024-03"",
      ""total"": 4,
      ""in_service"": 0
    },
    {
      ""month_year"": ""2024-04"",
      ""total"": 10,
      ""in_service"": 3
    },
    {
      ""month_year"": ""2024-05"",
      ""total"": 3,
      ""in_service"": 1
    },
    {
      ""month_year"": ""2024-06"",
      ""total"": 5,
      ""in_service"": 5
    },
    {
      ""month_year"": ""2024-07"",
      ""total"": 9,
      ""in_service"": 6
    },
    {
      ""month_year"": ""2024-08"",
      ""total"": 8,
      ""in_service"": 4
    },
    {
      ""month_year"": ""2024-09"",
      ""total"": 4,
      ""in_service"": 3
    },
    {
      ""month_year"": ""2024-10"",
      ""total"": 42,
      ""in_service"": 31
    },
    {
      ""month_year"": ""2024-11"",
      ""total"": 25,
      ""in_service"": 20
    },
    {
      ""month_year"": ""2024-12"",
      ""total"": 7,
      ""in_service"": 3
    },
    {
      ""month_year"": ""2025-01"",
      ""total"": 1,
      ""in_service"": 1
    },
    {
      ""month_year"": ""2025-02"",
      ""total"": 23,
      ""in_service"": 11
    },
    {
      ""month_year"": ""2025-03"",
      ""total"": 11,
      ""in_service"": 6
    },
    {
      ""month_year"": ""2025-04"",
      ""total"": 9,
      ""in_service"": 4
    },
    {
      ""month_year"": ""2025-05"",
      ""total"": 8,
      ""in_service"": 4
    },
    {
      ""month_year"": ""2025-06"",
      ""total"": 3,
      ""in_service"": 2
    },
    {
      ""month_year"": ""2025-07"",
      ""total"": 7,
      ""in_service"": 2
    },
    {
      ""month_year"": ""2025-08"",
      ""total"": 3,
      ""in_service"": 0
    },
    {
      ""month_year"": ""2025-09"",
      ""total"": 6,
      ""in_service"": 5
    },
    {
      ""month_year"": ""2025-10"",
      ""total"": 6,
      ""in_service"": 1
    },
    {
      ""month_year"": ""2025-11"",
      ""total"": 2,
      ""in_service"": 1
    },
    {
      ""month_year"": ""2025-12"",
      ""total"": 2,
      ""in_service"": 0
    },
    {
      ""month_year"": ""2026-01"",
      ""total"": 3,
      ""in_service"": 3
    },
    {
      ""month_year"": ""2026-02"",
      ""total"": 9,
      ""in_service"": 2
    },
    {
      ""month_year"": ""2026-03"",
      ""total"": 3,
      ""in_service"": 2
    },
    {
      ""month_year"": ""9999-01"",
      ""total"": 1,
      ""in_service"": 0
    }
  ],
  ""health_issues_detail"": [
    {
      ""issue"": ""Overdue for Check-in"",
      ""count"": 553
    },
    {
      ""issue"": ""Camera Issue"",
      ""count"": 20
    },
    {
      ""issue"": ""Power Disconnects"",
      ""count"": 9
    },
    {
      ""issue"": ""Hub Issue"",
      ""count"": 5
    },
    {
      ""issue"": ""SD Card Issue"",
      ""count"": 4
    },
    {
      ""issue"": ""Wrong Status"",
      ""count"": 1
    }
  ],
  ""comm_staleness"": [
    {
      ""bucket"": ""Today"",
      ""count"": 4
    },
    {
      ""bucket"": ""1-7 days"",
      ""count"": 11
    },
    {
      ""bucket"": ""8-30 days"",
      ""count"": 16
    },
    {
      ""bucket"": ""31-90 days"",
      ""count"": 15
    },
    {
      ""bucket"": ""91-180 days"",
      ""count"": 49
    },
    {
      ""bucket"": ""181-365 days"",
      ""count"": 549
    },
    {
      ""bucket"": ""365+ days"",
      ""count"": 11
    }
  ],
  ""never_communicated"": 1088,
  ""status_by_device_type"": [
    {
      ""device_type"": ""3D"",
      ""In Service"": 1,
      ""Open RMA"": 0,
      ""Out Of Service - Attached"": 0,
      ""Out Of Service - Unattached"": 0,
      ""Spare"": 0
    },
    {
      ""device_type"": ""AVM"",
      ""In Service"": 0,
      ""Open RMA"": 0,
      ""Out Of Service - Attached"": 0,
      ""Out Of Service - Unattached"": 1,
      ""Spare"": 0
    },
    {
      ""device_type"": ""DC2"",
      ""In Service"": 4,
      ""Open RMA"": 0,
      ""Out Of Service - Attached"": 0,
      ""Out Of Service - Unattached"": 52,
      ""Spare"": 4
    },
    {
      ""device_type"": ""DC3"",
      ""In Service"": 180,
      ""Open RMA"": 0,
      ""Out Of Service - Attached"": 7,
      ""Out Of Service - Unattached"": 102,
      ""Spare"": 12
    },
    {
      ""device_type"": ""DC3P"",
      ""In Service"": 180,
      ""Open RMA"": 0,
      ""Out Of Service - Attached"": 4,
      ""Out Of Service - Unattached"": 32,
      ""Spare"": 0
    },
    {
      ""device_type"": ""GO9"",
      ""In Service"": 5,
      ""Open RMA"": 0,
      ""Out Of Service - Attached"": 0,
      ""Out Of Service - Unattached"": 4,
      ""Spare"": 0
    },
    {
      ""device_type"": ""GO9B"",
      ""In Service"": 1,
      ""Open RMA"": 0,
      ""Out Of Service - Attached"": 0,
      ""Out Of Service - Unattached"": 0,
      ""Spare"": 0
    },
    {
      ""device_type"": ""GoAnywhere"",
      ""In Service"": 2,
      ""Open RMA"": 0,
      ""Out Of Service - Attached"": 0,
      ""Out Of Service - Unattached"": 3,
      ""Spare"": 0
    },
    {
      ""device_type"": ""Other"",
      ""In Service"": 5,
      ""Open RMA"": 0,
      ""Out Of Service - Attached"": 1,
      ""Out Of Service - Unattached"": 67,
      ""Spare"": 1
    },
    {
      ""device_type"": ""SF1"",
      ""In Service"": 34,
      ""Open RMA"": 0,
      ""Out Of Service - Attached"": 3,
      ""Out Of Service - Unattached"": 138,
      ""Spare"": 2
    },
    {
      ""device_type"": ""SF200"",
      ""In Service"": 2,
      ""Open RMA"": 0,
      ""Out Of Service - Attached"": 0,
      ""Out Of Service - Unattached"": 4,
      ""Spare"": 0
    },
    {
      ""device_type"": ""SF300"",
      ""In Service"": 60,
      ""Open RMA"": 0,
      ""Out Of Service - Attached"": 7,
      ""Out Of Service - Unattached"": 59,
      ""Spare"": 2
    },
    {
      ""device_type"": ""SF300V2"",
      ""In Service"": 11,
      ""Open RMA"": 0,
      ""Out Of Service - Attached"": 5,
      ""Out Of Service - Unattached"": 2,
      ""Spare"": 1
    },
    {
      ""device_type"": ""SF300W"",
      ""In Service"": 4,
      ""Open RMA"": 0,
      ""Out Of Service - Attached"": 2,
      ""Out Of Service - Unattached"": 13,
      ""Spare"": 0
    },
    {
      ""device_type"": ""SF400"",
      ""In Service"": 76,
      ""Open RMA"": 6,
      ""Out Of Service - Attached"": 10,
      ""Out Of Service - Unattached"": 31,
      ""Spare"": 9
    },
    {
      ""device_type"": ""SF400V2"",
      ""In Service"": 1,
      ""Open RMA"": 0,
      ""Out Of Service - Attached"": 0,
      ""Out Of Service - Unattached"": 0,
      ""Spare"": 0
    },
    {
      ""device_type"": ""SF500"",
      ""In Service"": 6,
      ""Open RMA"": 0,
      ""Out Of Service - Attached"": 1,
      ""Out Of Service - Unattached"": 5,
      ""Spare"": 0
    },
    {
      ""device_type"": ""SF64"",
      ""In Service"": 14,
      ""Open RMA"": 0,
      ""Out Of Service - Attached"": 1,
      ""Out Of Service - Unattached"": 67,
      ""Spare"": 4
    },
    {
      ""device_type"": ""SV2"",
      ""In Service"": 22,
      ""Open RMA"": 0,
      ""Out Of Service - Attached"": 2,
      ""Out Of Service - Unattached"": 440,
      ""Spare"": 1
    },
    {
      ""device_type"": ""Unknown"",
      ""In Service"": 2,
      ""Open RMA"": 0,
      ""Out Of Service - Attached"": 0,
      ""Out Of Service - Unattached"": 36,
      ""Spare"": 0
    },
    {
      ""device_type"": ""XT4500"",
      ""In Service"": 1,
      ""Open RMA"": 0,
      ""Out Of Service - Attached"": 1,
      ""Out Of Service - Unattached"": 3,
      ""Spare"": 0
    },
    {
      ""device_type"": ""hwplatformtestAPIabcd"",
      ""In Service"": 0,
      ""Open RMA"": 0,
      ""Out Of Service - Attached"": 0,
      ""Out Of Service - Unattached"": 1,
      ""Spare"": 0
    },
    {
      ""device_type"": ""plat"",
      ""In Service"": 0,
      ""Open RMA"": 0,
      ""Out Of Service - Attached"": 0,
      ""Out Of Service - Unattached"": 1,
      ""Spare"": 0
    }
  ],
  ""by_aux_cam_count"": [
    {
      ""cam_count"": 1,
      ""count"": 2
    },
    {
      ""cam_count"": 2,
      ""count"": 1
    },
    {
      ""cam_count"": 3,
      ""count"": 3
    },
    {
      ""cam_count"": 4,
      ""count"": 5
    }
  ]

        }";
    }
}

