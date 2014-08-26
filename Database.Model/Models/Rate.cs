using System;
using System.Collections.Generic;

namespace Database.Model.Models
{
    public partial class Rate
    {
        public long sr { get; set; }
        public long hotel_id { get; set; }
        public string room_type { get; set; }
        public string room_category { get; set; }
        public string room_description { get; set; }
        public string room_type_code { get; set; }
        public string inclusion { get; set; }
        public Nullable<decimal> amount { get; set; }
        public string currency { get; set; }
        public string rack_rate { get; set; }
        public Nullable<System.DateTime> valid_from { get; set; }
        public Nullable<System.DateTime> valid_till { get; set; }
        public Nullable<decimal> tax { get; set; }
        public string rate_disclaimer { get; set; }
        public string added_by { get; set; }
        public Nullable<System.DateTime> added_on { get; set; }
        public string updated_by { get; set; }
        public Nullable<System.DateTime> updated_on { get; set; }
        public Nullable<int> allocations { get; set; }
        public Nullable<double> max_guest { get; set; }
        public Nullable<double> max_adult { get; set; }
        public Nullable<double> max_child { get; set; }
        public Nullable<double> min_adult { get; set; }
        public Nullable<double> min_child { get; set; }
        public string extra_adult { get; set; }
        public string extra_child { get; set; }
        public string display_rate { get; set; }
        public Nullable<int> nights { get; set; }
        public string stat { get; set; }
        public string valdays { get; set; }
    }
}
