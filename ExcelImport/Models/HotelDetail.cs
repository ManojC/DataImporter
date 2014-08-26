using System;
using System.Collections.Generic;

namespace ExcelImport.Models
{
    public partial class HotelDetail
    {
        public long sr { get; set; }
        public string hotel_name { get; set; }
        public string hotel_code { get; set; }
        public string phone { get; set; }
        public string fax { get; set; }
        public string email { get; set; }
        public string website { get; set; }
        public string chain { get; set; }
        public string check_in { get; set; }
        public string check_out { get; set; }
        public string guarantee_policy { get; set; }
        public string cancel_policy { get; set; }
        public string card_accepted { get; set; }
        public string added_by { get; set; }
        public Nullable<System.DateTime> added_on { get; set; }
        public string updated_by { get; set; }
        public Nullable<System.DateTime> updated_on { get; set; }
        public string status { get; set; }
        public string amenities { get; set; }
        public Nullable<double> existing_id { get; set; }
        public string hotel_class { get; set; }
        public string description { get; set; }
        public string contactperson { get; set; }
        public Nullable<double> totnumber { get; set; }
        public string approved_by { get; set; }
        public Nullable<System.DateTime> approved_on { get; set; }
        public string vendorid { get; set; }
        public string appass { get; set; }
        public string expediaid { get; set; }
    }
}
