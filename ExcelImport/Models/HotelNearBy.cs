using System;
using System.Collections.Generic;

namespace ExcelImport.Models
{
    public partial class HotelNearBy
    {
        public long sr { get; set; }
        public long hotel_id { get; set; }
        public string typ { get; set; }
        public string name { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string distance_km { get; set; }
        public string distance_mi { get; set; }
        public string added_by { get; set; }
        public Nullable<System.DateTime> added_on { get; set; }
        public string updated_by { get; set; }
        public Nullable<System.DateTime> updated_on { get; set; }
    }
}
