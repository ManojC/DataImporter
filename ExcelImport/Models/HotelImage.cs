using System;
using System.Collections.Generic;

namespace ExcelImport.Models
{
    public partial class HotelImage
    {
        public long sr { get; set; }
        public long hotel_id { get; set; }
        public string thumb_url { get; set; }
        public string full_url { get; set; }
        public string image_category { get; set; }
        public string image_caption { get; set; }
        public string added_by { get; set; }
        public Nullable<System.DateTime> added_on { get; set; }
        public string updated_by { get; set; }
        public Nullable<System.DateTime> updated_on { get; set; }
    }
}
