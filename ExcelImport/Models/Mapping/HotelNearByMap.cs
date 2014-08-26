using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ExcelImport.Models.Mapping
{
    public class HotelNearByMap : EntityTypeConfiguration<HotelNearBy>
    {
        public HotelNearByMap()
        {
            // Primary Key
            this.HasKey(t => new { t.sr, t.hotel_id });

            // Properties
            this.Property(t => t.sr)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.hotel_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("HotelNearBy");
            this.Property(t => t.sr).HasColumnName("sr");
            this.Property(t => t.hotel_id).HasColumnName("hotel_id");
            this.Property(t => t.typ).HasColumnName("typ");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.latitude).HasColumnName("latitude");
            this.Property(t => t.longitude).HasColumnName("longitude");
            this.Property(t => t.distance_km).HasColumnName("distance-km");
            this.Property(t => t.distance_mi).HasColumnName("distance-mi");
            this.Property(t => t.added_by).HasColumnName("added_by");
            this.Property(t => t.added_on).HasColumnName("added_on");
            this.Property(t => t.updated_by).HasColumnName("updated_by");
            this.Property(t => t.updated_on).HasColumnName("updated_on");
        }
    }
}
