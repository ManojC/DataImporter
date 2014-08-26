using System;
using System.Collections.Generic;

namespace ExcelImport.Models
{
    public partial class HotelLocationInfo
    {
        public long sr { get; set; }
        public Nullable<long> hotel_id { get; set; }
        public string address { get; set; }
        public string locality { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string country_code { get; set; }
        public string zip { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string location_type { get; set; }
        public string hotel_area_highlights { get; set; }
        public string hotel_attractions { get; set; }
        public string hotel_driving_directions { get; set; }
        public string hotel_businesses { get; set; }
        public string hotel_points_of_interest { get; set; }
        public string added_by { get; set; }
        public Nullable<System.DateTime> added_on { get; set; }
        public string updated_by { get; set; }
        public Nullable<System.DateTime> updated_on { get; set; }
    }
}
