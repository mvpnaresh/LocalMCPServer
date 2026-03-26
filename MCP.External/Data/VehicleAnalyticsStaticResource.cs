using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCP.External.Data
{
    internal static class VehicleAnalyticsStaticResource
    {
        internal static readonly string VehicleAnalyticsJson = @"{
            
  ""summary"": {
    ""total_vehicles"": 30173,
    ""in_service"": 20210,
    ""out_of_service"": 9072,
    ""spare"": 64,
    ""removed"": 5,
    ""pending_removal"": 4,
    ""unknown_status"": 818,
    ""eld_enabled"": 123,
    ""dvir_enabled"": 1655,
    ""has_check_in"": 2285,
    ""never_checked_in"": 27888
  },
  ""by_status"": [
    {
      ""status"": ""In Service"",
      ""count"": 20210
    },
    {
      ""status"": ""Out Of Service"",
      ""count"": 9072
    },
    {
      ""status"": ""Unknown"",
      ""count"": 818
    },
    {
      ""status"": ""Spare"",
      ""count"": 64
    },
    {
      ""status"": ""Removed From Fleet"",
      ""count"": 5
    },
    {
      ""status"": ""Pending Removal From Fleet"",
      ""count"": 4
    }
  ],
  ""by_vehicle_type"": [
    {
      ""vehicle_type"": ""Truck (delivery)"",
      ""total"": 10512,
      ""in_service"": 9611,
      ""out_of_service"": 900
    },
    {
      ""vehicle_type"": ""Car"",
      ""total"": 9452,
      ""in_service"": 7042,
      ""out_of_service"": 2393
    },
    {
      ""vehicle_type"": ""Unassigned"",
      ""total"": 3749,
      ""in_service"": 1461,
      ""out_of_service"": 1446
    },
    {
      ""vehicle_type"": ""Tanker"",
      ""total"": 2087,
      ""in_service"": 13,
      ""out_of_service"": 2072
    },
    {
      ""vehicle_type"": ""Bus (large)"",
      ""total"": 944,
      ""in_service"": 170,
      ""out_of_service"": 769
    },
    {
      ""vehicle_type"": ""Tractor trailer"",
      ""total"": 568,
      ""in_service"": 547,
      ""out_of_service"": 20
    },
    {
      ""vehicle_type"": ""Loader (front)"",
      ""total"": 554,
      ""in_service"": 6,
      ""out_of_service"": 547
    },
    {
      ""vehicle_type"": ""Truck - Other"",
      ""total"": 457,
      ""in_service"": 429,
      ""out_of_service"": 25
    },
    {
      ""vehicle_type"": ""Sedan / Coupe - Other"",
      ""total"": 417,
      ""in_service"": 289,
      ""out_of_service"": 124
    },
    {
      ""vehicle_type"": ""Taxi"",
      ""total"": 232,
      ""in_service"": 22,
      ""out_of_service"": 210
    },
    {
      ""vehicle_type"": ""Limousine (stretch)"",
      ""total"": 185,
      ""in_service"": 1,
      ""out_of_service"": 184
    },
    {
      ""vehicle_type"": ""Multi-Tanker"",
      ""total"": 164,
      ""in_service"": 5,
      ""out_of_service"": 159
    },
    {
      ""vehicle_type"": ""Ambulance"",
      ""total"": 139,
      ""in_service"": 118,
      ""out_of_service"": 18
    },
    {
      ""vehicle_type"": ""Pickup (standard)"",
      ""total"": 97,
      ""in_service"": 95,
      ""out_of_service"": 0
    },
    {
      ""vehicle_type"": ""Bus - Other"",
      ""total"": 77,
      ""in_service"": 58,
      ""out_of_service"": 18
    },
    {
      ""vehicle_type"": ""Hauler / Dump Truck / Heavy"",
      ""total"": 61,
      ""in_service"": 46,
      ""out_of_service"": 15
    },
    {
      ""vehicle_type"": ""Paratransit / Cutaway"",
      ""total"": 56,
      ""in_service"": 0,
      ""out_of_service"": 55
    },
    {
      ""vehicle_type"": ""Pickup (one ton)"",
      ""total"": 54,
      ""in_service"": 51,
      ""out_of_service"": 3
    },
    {
      ""vehicle_type"": ""Sport utility vehicle"",
      ""total"": 47,
      ""in_service"": 44,
      ""out_of_service"": 3
    },
    {
      ""vehicle_type"": ""Limousine"",
      ""total"": 45,
      ""in_service"": 9,
      ""out_of_service"": 35
    },
    {
      ""vehicle_type"": ""Police car"",
      ""total"": 40,
      ""in_service"": 7,
      ""out_of_service"": 33
    },
    {
      ""vehicle_type"": ""Bus (small)"",
      ""total"": 35,
      ""in_service"": 28,
      ""out_of_service"": 4
    },
    {
      ""vehicle_type"": ""Tow truck"",
      ""total"": 34,
      ""in_service"": 32,
      ""out_of_service"": 1
    },
    {
      ""vehicle_type"": ""Truck (fixed heavy load)"",
      ""total"": 34,
      ""in_service"": 28,
      ""out_of_service"": 5
    },
    {
      ""vehicle_type"": ""Delivery van"",
      ""total"": 28,
      ""in_service"": 25,
      ""out_of_service"": 2
    },
    {
      ""vehicle_type"": ""Van - Other"",
      ""total"": 21,
      ""in_service"": 9,
      ""out_of_service"": 12
    },
    {
      ""vehicle_type"": ""Mini-van"",
      ""total"": 13,
      ""in_service"": 12,
      ""out_of_service"": 1
    },
    {
      ""vehicle_type"": ""Fire truck"",
      ""total"": 11,
      ""in_service"": 10,
      ""out_of_service"": 1
    },
    {
      ""vehicle_type"": ""Multi-Tractor trailer"",
      ""total"": 10,
      ""in_service"": 8,
      ""out_of_service"": 2
    },
    {
      ""vehicle_type"": ""Coach"",
      ""total"": 10,
      ""in_service"": 7,
      ""out_of_service"": 2
    },
    {
      ""vehicle_type"": ""Mixer"",
      ""total"": 8,
      ""in_service"": 2,
      ""out_of_service"": 6
    },
    {
      ""vehicle_type"": ""Truck (armored)"",
      ""total"": 7,
      ""in_service"": 6,
      ""out_of_service"": 1
    },
    {
      ""vehicle_type"": ""Standard van"",
      ""total"": 6,
      ""in_service"": 5,
      ""out_of_service"": 1
    },
    {
      ""vehicle_type"": ""Roll-off"",
      ""total"": 5,
      ""in_service"": 4,
      ""out_of_service"": 1
    },
    {
      ""vehicle_type"": ""Propane Bobtail"",
      ""total"": 4,
      ""in_service"": 2,
      ""out_of_service"": 2
    },
    {
      ""vehicle_type"": ""Mini-van (taxi)"",
      ""total"": 3,
      ""in_service"": 3,
      ""out_of_service"": 0
    },
    {
      ""vehicle_type"": ""Cutaway (Small Bus)"",
      ""total"": 2,
      ""in_service"": 2,
      ""out_of_service"": 0
    },
    {
      ""vehicle_type"": ""Loader (rear)"",
      ""total"": 2,
      ""in_service"": 2,
      ""out_of_service"": 0
    },
    {
      ""vehicle_type"": ""Loader (side)"",
      ""total"": 2,
      ""in_service"": 1,
      ""out_of_service"": 1
    },
    {
      ""vehicle_type"": ""Equipment Mover"",
      ""total"": 1,
      ""in_service"": 0,
      ""out_of_service"": 1
    }
  ],
  ""by_make"": [
    {
      ""make"": ""PETERBILT"",
      ""total"": 7656,
      ""in_service"": 6662
    },
    {
      ""make"": ""2231545 ONTARIO"",
      ""total"": 2294,
      ""in_service"": 0
    },
    {
      ""make"": ""HINO"",
      ""total"": 1745,
      ""in_service"": 0
    },
    {
      ""make"": ""FORD"",
      ""total"": 1246,
      ""in_service"": 57
    },
    {
      ""make"": ""MACK"",
      ""total"": 550,
      ""in_service"": 21
    },
    {
      ""make"": ""FREIGHTLINER"",
      ""total"": 362,
      ""in_service"": 222
    },
    {
      ""make"": ""RAM"",
      ""total"": 304,
      ""in_service"": 1
    },
    {
      ""make"": ""ISUZU"",
      ""total"": 265,
      ""in_service"": 1
    },
    {
      ""make"": ""INTERNATIONAL"",
      ""total"": 226,
      ""in_service"": 9
    },
    {
      ""make"": ""1/OFF KUSTOMS, LLC"",
      ""total"": 191,
      ""in_service"": 127
    },
    {
      ""make"": ""CHEVROLET"",
      ""total"": 176,
      ""in_service"": 62
    },
    {
      ""make"": ""VOLVO TRUCK"",
      ""total"": 168,
      ""in_service"": 19
    },
    {
      ""make"": ""TOYOTA"",
      ""total"": 147,
      ""in_service"": 81
    },
    {
      ""make"": ""ACURA"",
      ""total"": 131,
      ""in_service"": 27
    },
    {
      ""make"": ""102 IRONWORKS, INC."",
      ""total"": 101,
      ""in_service"": 37
    }
  ],
  ""by_year_bucket"": [
    {
      ""year_bucket"": ""\u22641989"",
      ""count"": 2745
    },
    {
      ""year_bucket"": ""1990s"",
      ""count"": 165
    },
    {
      ""year_bucket"": ""2000s"",
      ""count"": 617
    },
    {
      ""year_bucket"": ""2010\u201314"",
      ""count"": 562
    },
    {
      ""year_bucket"": ""2015\u201319"",
      ""count"": 2448
    },
    {
      ""year_bucket"": ""2020\u201321"",
      ""count"": 1182
    },
    {
      ""year_bucket"": ""2022\u201323"",
      ""count"": 1010
    },
    {
      ""year_bucket"": ""2024"",
      ""count"": 1236
    },
    {
      ""year_bucket"": ""2025"",
      ""count"": 65
    },
    {
      ""year_bucket"": ""2026+"",
      ""count"": 4
    }
  ],
  ""by_model_year"": [
    {
      ""year"": 2027,
      ""total"": 1,
      ""in_service"": 0
    },
    {
      ""year"": 2026,
      ""total"": 3,
      ""in_service"": 3
    },
    {
      ""year"": 2025,
      ""total"": 65,
      ""in_service"": 13
    },
    {
      ""year"": 2024,
      ""total"": 1236,
      ""in_service"": 23
    },
    {
      ""year"": 2023,
      ""total"": 264,
      ""in_service"": 38
    },
    {
      ""year"": 2022,
      ""total"": 746,
      ""in_service"": 38
    },
    {
      ""year"": 2021,
      ""total"": 403,
      ""in_service"": 45
    },
    {
      ""year"": 2020,
      ""total"": 779,
      ""in_service"": 112
    },
    {
      ""year"": 2019,
      ""total"": 866,
      ""in_service"": 119
    },
    {
      ""year"": 2018,
      ""total"": 555,
      ""in_service"": 140
    },
    {
      ""year"": 2017,
      ""total"": 400,
      ""in_service"": 42
    },
    {
      ""year"": 2016,
      ""total"": 361,
      ""in_service"": 91
    },
    {
      ""year"": 2015,
      ""total"": 266,
      ""in_service"": 32
    },
    {
      ""year"": 2014,
      ""total"": 165,
      ""in_service"": 24
    },
    {
      ""year"": 2013,
      ""total"": 175,
      ""in_service"": 48
    },
    {
      ""year"": 2012,
      ""total"": 114,
      ""in_service"": 38
    },
    {
      ""year"": 2011,
      ""total"": 69,
      ""in_service"": 20
    },
    {
      ""year"": 2010,
      ""total"": 39,
      ""in_service"": 18
    }
  ],
  ""by_group"": [
    {
      ""group"": ""Adam McCarty- Kami IND"",
      ""total"": 9507,
      ""in_service"": 9503,
      ""out_of_service"": 4,
      ""eld_enabled"": 1,
      ""dvir_enabled"": 2
    },
    {
      ""group"": ""Ag\u00fcante Lytx"",
      ""total"": 5740,
      ""in_service"": 5739,
      ""out_of_service"": 1,
      ""eld_enabled"": 0,
      ""dvir_enabled"": 0
    },
    {
      ""group"": ""Aux Camera Waste Management Pilot"",
      ""total"": 2794,
      ""in_service"": 0,
      ""out_of_service"": 2794,
      ""eld_enabled"": 0,
      ""dvir_enabled"": 0
    },
    {
      ""group"": ""###DC4DC"",
      ""total"": 2693,
      ""in_service"": 211,
      ""out_of_service"": 2473,
      ""eld_enabled"": 6,
      ""dvir_enabled"": 210
    },
    {
      ""group"": ""San Diego HQ"",
      ""total"": 1608,
      ""in_service"": 2,
      ""out_of_service"": 1606,
      ""eld_enabled"": 0,
      ""dvir_enabled"": 0
    },
    {
      ""group"": ""Emma GROUP Test 6 - 2"",
      ""total"": 1531,
      ""in_service"": 829,
      ""out_of_service"": 0,
      ""eld_enabled"": 0,
      ""dvir_enabled"": 0
    },
    {
      ""group"": ""***Root"",
      ""total"": 1441,
      ""in_service"": 865,
      ""out_of_service"": 551,
      ""eld_enabled"": 24,
      ""dvir_enabled"": 566
    },
    {
      ""group"": ""Cellular Unassigned"",
      ""total"": 518,
      ""in_service"": 391,
      ""out_of_service"": 18,
      ""eld_enabled"": 0,
      ""dvir_enabled"": 14
    },
    {
      ""group"": ""#LegacyUserTesting"",
      ""total"": 480,
      ""in_service"": 29,
      ""out_of_service"": 451,
      ""eld_enabled"": 15,
      ""dvir_enabled"": 11
    },
    {
      ""group"": ""***CANADA Sim Test"",
      ""total"": 433,
      ""in_service"": 342,
      ""out_of_service"": 87,
      ""eld_enabled"": 1,
      ""dvir_enabled"": 27
    },
    {
      ""group"": ""Default"",
      ""total"": 378,
      ""in_service"": 364,
      ""out_of_service"": 12,
      ""eld_enabled"": 0,
      ""dvir_enabled"": 141
    },
    {
      ""group"": ""Default B"",
      ""total"": 269,
      ""in_service"": 268,
      ""out_of_service"": 1,
      ""eld_enabled"": 0,
      ""dvir_enabled"": 0
    },
    {
      ""group"": ""***BBacademy bus1"",
      ""total"": 252,
      ""in_service"": 75,
      ""out_of_service"": 170,
      ""eld_enabled"": 7,
      ""dvir_enabled"": 13
    },
    {
      ""group"": ""Lytx dev leader solution-RENAME"",
      ""total"": 166,
      ""in_service"": 155,
      ""out_of_service"": 11,
      ""eld_enabled"": 1,
      ""dvir_enabled"": 39
    },
    {
      ""group"": ""PSB-test"",
      ""total"": 120,
      ""in_service"": 55,
      ""out_of_service"": 63,
      ""eld_enabled"": 0,
      ""dvir_enabled"": 0
    },
    {
      ""group"": ""$%Groups"",
      ""total"": 73,
      ""in_service"": 3,
      ""out_of_service"": 69,
      ""eld_enabled"": 0,
      ""dvir_enabled"": 0
    },
    {
      ""group"": ""*** BNSF MVAI Edited"",
      ""total"": 57,
      ""in_service"": 24,
      ""out_of_service"": 33,
      ""eld_enabled"": 1,
      ""dvir_enabled"": 4
    },
    {
      ""group"": ""###heidi"",
      ""total"": 53,
      ""in_service"": 1,
      ""out_of_service"": 52,
      ""eld_enabled"": 37,
      ""dvir_enabled"": 9
    },
    {
      ""group"": ""***DBlack Test"",
      ""total"": 51,
      ""in_service"": 34,
      ""out_of_service"": 17,
      ""eld_enabled"": 0,
      ""dvir_enabled"": 46
    },
    {
      ""group"": ""lab"",
      ""total"": 48,
      ""in_service"": 40,
      ""out_of_service"": 8,
      ""eld_enabled"": 1,
      ""dvir_enabled"": 0
    }
  ],
  ""by_state"": [
    {
      ""state"": ""US-TX"",
      ""count"": 4916
    },
    {
      ""state"": ""US-AL"",
      ""count"": 4757
    },
    {
      ""state"": ""US-CA"",
      ""count"": 868
    },
    {
      ""state"": ""US-AK"",
      ""count"": 116
    },
    {
      ""state"": ""US-AZ"",
      ""count"": 42
    },
    {
      ""state"": ""US-CO"",
      ""count"": 28
    },
    {
      ""state"": ""US-MA"",
      ""count"": 23
    },
    {
      ""state"": ""US-WA"",
      ""count"": 22
    },
    {
      ""state"": ""US-IL"",
      ""count"": 22
    },
    {
      ""state"": ""US-as"",
      ""count"": 19
    },
    {
      ""state"": ""US-ID"",
      ""count"": 11
    },
    {
      ""state"": ""California"",
      ""count"": 10
    },
    {
      ""state"": ""US-FL"",
      ""count"": 9
    },
    {
      ""state"": ""US-GA"",
      ""count"": 8
    },
    {
      ""state"": ""US-HI"",
      ""count"": 7
    }
  ],
  ""by_hibernation"": [
    {
      ""hibernation"": ""0.25 Hour"",
      ""count"": 14961
    },
    {
      ""hibernation"": ""1 Hour"",
      ""count"": 12546
    },
    {
      ""hibernation"": ""20.25 Hour"",
      ""count"": 1106
    },
    {
      ""hibernation"": ""8 Hour"",
      ""count"": 574
    },
    {
      ""hibernation"": ""4 Hour"",
      ""count"": 406
    },
    {
      ""hibernation"": ""60 Hour"",
      ""count"": 316
    },
    {
      ""hibernation"": ""0.02 Hour"",
      ""count"": 154
    },
    {
      ""hibernation"": ""12 Hour"",
      ""count"": 42
    },
    {
      ""hibernation"": ""Not Set"",
      ""count"": 38
    },
    {
      ""hibernation"": ""18 Hour"",
      ""count"": 30
    }
  ],
  ""eld_dvir"": {
    ""eld"": {
      ""Enabled"": 123,
      ""Disabled"": 30050
    },
    ""dvir"": {
      ""Enabled"": 1655,
      ""Disabled"": 28518
    }
  },
  ""by_seat_belt"": [
    {
      ""seat_belt_type"": ""Shoulder Harness"",
      ""count"": 16972
    },
    {
      ""seat_belt_type"": ""Not Set"",
      ""count"": 10249
    },
    {
      ""seat_belt_type"": ""Unassigned"",
      ""count"": 2676
    },
    {
      ""seat_belt_type"": ""Lap Belt"",
      ""count"": 276
    }
  ],
  ""by_inspection_list"": [
    {
      ""inspection_list"": ""Default"",
      ""count"": 28716
    },
    {
      ""inspection_list"": ""Not Set"",
      ""count"": 1395
    },
    {
      ""inspection_list"": ""Jennatest0918, Jennatest091801"",
      ""count"": 8
    },
    {
      ""inspection_list"": ""gqzftm"",
      ""count"": 3
    },
    {
      ""inspection_list"": ""Rexel Test List"",
      ""count"": 3
    },
    {
      ""inspection_list"": ""Elsa test_weekly, Elsa test_yearly"",
      ""count"": 2
    },
    {
      ""inspection_list"": ""Default, Test_InspectionList_Default"",
      ""count"": 2
    },
    {
      ""inspection_list"": ""ofttgy, oazvah"",
      ""count"": 2
    },
    {
      ""inspection_list"": ""Mithra"",
      ""count"": 2
    },
    {
      ""inspection_list"": ""Default, Feli test"",
      ""count"": 2
    }
  ],
  ""type_by_status"": [
    {
      ""vehicle_type"": ""Ambulance"",
      ""In Service"": 118,
      ""Out Of Service"": 18,
      ""Pending Removal From Fleet"": 0,
      ""Removed From Fleet"": 0,
      ""Spare"": 3,
      ""Unknown"": 0
    },
    {
      ""vehicle_type"": ""Bus (large)"",
      ""In Service"": 170,
      ""Out Of Service"": 769,
      ""Pending Removal From Fleet"": 0,
      ""Removed From Fleet"": 0,
      ""Spare"": 5,
      ""Unknown"": 0
    },
    {
      ""vehicle_type"": ""Bus (small)"",
      ""In Service"": 28,
      ""Out Of Service"": 4,
      ""Pending Removal From Fleet"": 0,
      ""Removed From Fleet"": 1,
      ""Spare"": 2,
      ""Unknown"": 0
    },
    {
      ""vehicle_type"": ""Bus - Other"",
      ""In Service"": 58,
      ""Out Of Service"": 18,
      ""Pending Removal From Fleet"": 0,
      ""Removed From Fleet"": 1,
      ""Spare"": 0,
      ""Unknown"": 0
    },
    {
      ""vehicle_type"": ""Car"",
      ""In Service"": 7042,
      ""Out Of Service"": 2393,
      ""Pending Removal From Fleet"": 1,
      ""Removed From Fleet"": 0,
      ""Spare"": 2,
      ""Unknown"": 14
    },
    {
      ""vehicle_type"": ""Coach"",
      ""In Service"": 7,
      ""Out Of Service"": 2,
      ""Pending Removal From Fleet"": 0,
      ""Removed From Fleet"": 0,
      ""Spare"": 1,
      ""Unknown"": 0
    },
    {
      ""vehicle_type"": ""Cutaway (Small Bus)"",
      ""In Service"": 2,
      ""Out Of Service"": 0,
      ""Pending Removal From Fleet"": 0,
      ""Removed From Fleet"": 0,
      ""Spare"": 0,
      ""Unknown"": 0
    },
    {
      ""vehicle_type"": ""Delivery van"",
      ""In Service"": 25,
      ""Out Of Service"": 2,
      ""Pending Removal From Fleet"": 0,
      ""Removed From Fleet"": 0,
      ""Spare"": 1,
      ""Unknown"": 0
    },
    {
      ""vehicle_type"": ""Equipment Mover"",
      ""In Service"": 0,
      ""Out Of Service"": 1,
      ""Pending Removal From Fleet"": 0,
      ""Removed From Fleet"": 0,
      ""Spare"": 0,
      ""Unknown"": 0
    },
    {
      ""vehicle_type"": ""Fire truck"",
      ""In Service"": 10,
      ""Out Of Service"": 1,
      ""Pending Removal From Fleet"": 0,
      ""Removed From Fleet"": 0,
      ""Spare"": 0,
      ""Unknown"": 0
    },
    {
      ""vehicle_type"": ""Hauler / Dump Truck / Heavy"",
      ""In Service"": 46,
      ""Out Of Service"": 15,
      ""Pending Removal From Fleet"": 0,
      ""Removed From Fleet"": 0,
      ""Spare"": 0,
      ""Unknown"": 0
    },
    {
      ""vehicle_type"": ""Limousine"",
      ""In Service"": 9,
      ""Out Of Service"": 35,
      ""Pending Removal From Fleet"": 0,
      ""Removed From Fleet"": 0,
      ""Spare"": 0,
      ""Unknown"": 1
    },
    {
      ""vehicle_type"": ""Limousine (stretch)"",
      ""In Service"": 1,
      ""Out Of Service"": 184,
      ""Pending Removal From Fleet"": 0,
      ""Removed From Fleet"": 0,
      ""Spare"": 0,
      ""Unknown"": 0
    },
    {
      ""vehicle_type"": ""Loader (front)"",
      ""In Service"": 6,
      ""Out Of Service"": 547,
      ""Pending Removal From Fleet"": 0,
      ""Removed From Fleet"": 1,
      ""Spare"": 0,
      ""Unknown"": 0
    },
    {
      ""vehicle_type"": ""Loader (rear)"",
      ""In Service"": 2,
      ""Out Of Service"": 0,
      ""Pending Removal From Fleet"": 0,
      ""Removed From Fleet"": 0,
      ""Spare"": 0,
      ""Unknown"": 0
    },
    {
      ""vehicle_type"": ""Loader (side)"",
      ""In Service"": 1,
      ""Out Of Service"": 1,
      ""Pending Removal From Fleet"": 0,
      ""Removed From Fleet"": 0,
      ""Spare"": 0,
      ""Unknown"": 0
    },
    {
      ""vehicle_type"": ""Mini-van"",
      ""In Service"": 12,
      ""Out Of Service"": 1,
      ""Pending Removal From Fleet"": 0,
      ""Removed From Fleet"": 0,
      ""Spare"": 0,
      ""Unknown"": 0
    },
    {
      ""vehicle_type"": ""Mini-van (taxi)"",
      ""In Service"": 3,
      ""Out Of Service"": 0,
      ""Pending Removal From Fleet"": 0,
      ""Removed From Fleet"": 0,
      ""Spare"": 0,
      ""Unknown"": 0
    },
    {
      ""vehicle_type"": ""Mixer"",
      ""In Service"": 2,
      ""Out Of Service"": 6,
      ""Pending Removal From Fleet"": 0,
      ""Removed From Fleet"": 0,
      ""Spare"": 0,
      ""Unknown"": 0
    },
    {
      ""vehicle_type"": ""Multi-Tanker"",
      ""In Service"": 5,
      ""Out Of Service"": 159,
      ""Pending Removal From Fleet"": 0,
      ""Removed From Fleet"": 0,
      ""Spare"": 0,
      ""Unknown"": 0
    },
    {
      ""vehicle_type"": ""Multi-Tractor trailer"",
      ""In Service"": 8,
      ""Out Of Service"": 2,
      ""Pending Removal From Fleet"": 0,
      ""Removed From Fleet"": 0,
      ""Spare"": 0,
      ""Unknown"": 0
    },
    {
      ""vehicle_type"": ""Paratransit / Cutaway"",
      ""In Service"": 0,
      ""Out Of Service"": 55,
      ""Pending Removal From Fleet"": 0,
      ""Removed From Fleet"": 0,
      ""Spare"": 1,
      ""Unknown"": 0
    },
    {
      ""vehicle_type"": ""Pickup (one ton)"",
      ""In Service"": 51,
      ""Out Of Service"": 3,
      ""Pending Removal From Fleet"": 0,
      ""Removed From Fleet"": 0,
      ""Spare"": 0,
      ""Unknown"": 0
    },
    {
      ""vehicle_type"": ""Pickup (standard)"",
      ""In Service"": 95,
      ""Out Of Service"": 0,
      ""Pending Removal From Fleet"": 0,
      ""Removed From Fleet"": 0,
      ""Spare"": 2,
      ""Unknown"": 0
    },
    {
      ""vehicle_type"": ""Police car"",
      ""In Service"": 7,
      ""Out Of Service"": 33,
      ""Pending Removal From Fleet"": 0,
      ""Removed From Fleet"": 0,
      ""Spare"": 0,
      ""Unknown"": 0
    },
    {
      ""vehicle_type"": ""Propane Bobtail"",
      ""In Service"": 2,
      ""Out Of Service"": 2,
      ""Pending Removal From Fleet"": 0,
      ""Removed From Fleet"": 0,
      ""Spare"": 0,
      ""Unknown"": 0
    },
    {
      ""vehicle_type"": ""Roll-off"",
      ""In Service"": 4,
      ""Out Of Service"": 1,
      ""Pending Removal From Fleet"": 0,
      ""Removed From Fleet"": 0,
      ""Spare"": 0,
      ""Unknown"": 0
    },
    {
      ""vehicle_type"": ""Sedan / Coupe - Other"",
      ""In Service"": 289,
      ""Out Of Service"": 124,
      ""Pending Removal From Fleet"": 0,
      ""Removed From Fleet"": 1,
      ""Spare"": 3,
      ""Unknown"": 0
    },
    {
      ""vehicle_type"": ""Sport utility vehicle"",
      ""In Service"": 44,
      ""Out Of Service"": 3,
      ""Pending Removal From Fleet"": 0,
      ""Removed From Fleet"": 0,
      ""Spare"": 0,
      ""Unknown"": 0
    },
    {
      ""vehicle_type"": ""Standard van"",
      ""In Service"": 5,
      ""Out Of Service"": 1,
      ""Pending Removal From Fleet"": 0,
      ""Removed From Fleet"": 0,
      ""Spare"": 0,
      ""Unknown"": 0
    },
    {
      ""vehicle_type"": ""Tanker"",
      ""In Service"": 13,
      ""Out Of Service"": 2072,
      ""Pending Removal From Fleet"": 1,
      ""Removed From Fleet"": 0,
      ""Spare"": 1,
      ""Unknown"": 0
    },
    {
      ""vehicle_type"": ""Taxi"",
      ""In Service"": 22,
      ""Out Of Service"": 210,
      ""Pending Removal From Fleet"": 0,
      ""Removed From Fleet"": 0,
      ""Spare"": 0,
      ""Unknown"": 0
    },
    {
      ""vehicle_type"": ""Tow truck"",
      ""In Service"": 32,
      ""Out Of Service"": 1,
      ""Pending Removal From Fleet"": 0,
      ""Removed From Fleet"": 0,
      ""Spare"": 1,
      ""Unknown"": 0
    },
    {
      ""vehicle_type"": ""Tractor trailer"",
      ""In Service"": 547,
      ""Out Of Service"": 20,
      ""Pending Removal From Fleet"": 0,
      ""Removed From Fleet"": 0,
      ""Spare"": 1,
      ""Unknown"": 0
    },
    {
      ""vehicle_type"": ""Truck (armored)"",
      ""In Service"": 6,
      ""Out Of Service"": 1,
      ""Pending Removal From Fleet"": 0,
      ""Removed From Fleet"": 0,
      ""Spare"": 0,
      ""Unknown"": 0
    },
    {
      ""vehicle_type"": ""Truck (delivery)"",
      ""In Service"": 9611,
      ""Out Of Service"": 900,
      ""Pending Removal From Fleet"": 0,
      ""Removed From Fleet"": 0,
      ""Spare"": 1,
      ""Unknown"": 0
    },
    {
      ""vehicle_type"": ""Truck (fixed heavy load)"",
      ""In Service"": 28,
      ""Out Of Service"": 5,
      ""Pending Removal From Fleet"": 0,
      ""Removed From Fleet"": 0,
      ""Spare"": 1,
      ""Unknown"": 0
    },
    {
      ""vehicle_type"": ""Truck - Other"",
      ""In Service"": 429,
      ""Out Of Service"": 25,
      ""Pending Removal From Fleet"": 0,
      ""Removed From Fleet"": 0,
      ""Spare"": 3,
      ""Unknown"": 0
    },
    {
      ""vehicle_type"": ""Unassigned"",
      ""In Service"": 1461,
      ""Out Of Service"": 1446,
      ""Pending Removal From Fleet"": 2,
      ""Removed From Fleet"": 1,
      ""Spare"": 36,
      ""Unknown"": 803
    },
    {
      ""vehicle_type"": ""Van - Other"",
      ""In Service"": 9,
      ""Out Of Service"": 12,
      ""Pending Removal From Fleet"": 0,
      ""Removed From Fleet"": 0,
      ""Spare"": 0,
      ""Unknown"": 0
    }
  ],
  ""by_checkin_month"": [
    {
      ""month_year"": ""2024-07"",
      ""count"": 1
    },
    {
      ""month_year"": ""2024-11"",
      ""count"": 1
    },
    {
      ""month_year"": ""2024-12"",
      ""count"": 1
    },
    {
      ""month_year"": ""2025-01"",
      ""count"": 10
    },
    {
      ""month_year"": ""2025-02"",
      ""count"": 8
    },
    {
      ""month_year"": ""2025-03"",
      ""count"": 13
    },
    {
      ""month_year"": ""2025-04"",
      ""count"": 21
    },
    {
      ""month_year"": ""2025-05"",
      ""count"": 58
    },
    {
      ""month_year"": ""2025-06"",
      ""count"": 312
    },
    {
      ""month_year"": ""2025-07"",
      ""count"": 263
    },
    {
      ""month_year"": ""2025-08"",
      ""count"": 111
    },
    {
      ""month_year"": ""2025-09"",
      ""count"": 33
    },
    {
      ""month_year"": ""2025-10"",
      ""count"": 15
    },
    {
      ""month_year"": ""2025-11"",
      ""count"": 8
    },
    {
      ""month_year"": ""2025-12"",
      ""count"": 14
    },
    {
      ""month_year"": ""2026-01"",
      ""count"": 16
    },
    {
      ""month_year"": ""2026-02"",
      ""count"": 621
    },
    {
      ""month_year"": ""2026-03"",
      ""count"": 779
    }
  ]
        }";


    }
}

