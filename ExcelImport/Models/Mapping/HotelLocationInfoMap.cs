using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ExcelImport.Models.Mapping
{
    public class HotelLocationInfoMap : EntityTypeConfiguration<HotelLocationInfo>
    {
        public HotelLocationInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.sr);

            // Properties
            this.Property(t => t.sr)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("HotelLocationInfo");
            this.Property(t => t.sr).HasColumnName("sr");
            this.Property(t => t.hotel_id).HasColumnName("hotel_id");
            this.Property(t => t.address).HasColumnName("address");
            this.Property(t => t.locality).HasColumnName("locality");
            this.Property(t => t.city).HasColumnName("city");
            this.Property(t => t.state).HasColumnName("state");
            this.Property(t => t.country).HasColumnName("country");
            this.Property(t => t.country_code).HasColumnName("country_code");
            this.Property(t => t.zip).HasColumnName("zip");
            this.Property(t => t.latitude).HasColumnName("latitude");
            this.Property(t => t.longitude).HasColumnName("longitude");
            this.Property(t => t.location_type).HasColumnName("location-type");
            this.Property(t => t.hotel_area_highlights).HasColumnName("hotel-area-highlights");
            this.Property(t => t.hotel_attractions).HasColumnName("hotel-attractions");
            this.Property(t => t.hotel_driving_directions).HasColumnName("hotel-driving-directions");
            this.Property(t => t.hotel_businesses).HasColumnName("hotel-businesses");
            this.Property(t => t.hotel_points_of_interest).HasColumnName("hotel-points-of-interest");
            this.Property(t => t.added_by).HasColumnName("added_by");
            this.Property(t => t.added_on).HasColumnName("added_on");
            this.Property(t => t.updated_by).HasColumnName("updated_by");
            this.Property(t => t.updated_on).HasColumnName("updated_on");
        }
    }
}
