using System;
using System.Collections.Generic;

namespace ExcelImport.Models
{
    public partial class HotelRating
    {
        public long sr { get; set; }
        public long hotel_id { get; set; }
        public string rating_type { get; set; }
        public string rating_agency { get; set; }
        public string rating { get; set; }
        public string total_ratings { get; set; }
        public string rating_image_url { get; set; }
        public string added_by { get; set; }
        public Nullable<System.DateTime> added_on { get; set; }
        public string updated_by { get; set; }
        public Nullable<System.DateTime> updated_on { get; set; }
    }
}
