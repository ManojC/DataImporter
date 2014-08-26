using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ExcelImport.Models.Mapping
{
    public class HotelRatingMap : EntityTypeConfiguration<HotelRating>
    {
        public HotelRatingMap()
        {
            // Primary Key
            this.HasKey(t => new { t.sr, t.hotel_id });

            // Properties
            this.Property(t => t.sr)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.hotel_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("HotelRating");
            this.Property(t => t.sr).HasColumnName("sr");
            this.Property(t => t.hotel_id).HasColumnName("hotel_id");
            this.Property(t => t.rating_type).HasColumnName("rating_type");
            this.Property(t => t.rating_agency).HasColumnName("rating_agency");
            this.Property(t => t.rating).HasColumnName("rating");
            this.Property(t => t.total_ratings).HasColumnName("total_ratings");
            this.Property(t => t.rating_image_url).HasColumnName("rating_image_url");
            this.Property(t => t.added_by).HasColumnName("added_by");
            this.Property(t => t.added_on).HasColumnName("added_on");
            this.Property(t => t.updated_by).HasColumnName("updated_by");
            this.Property(t => t.updated_on).HasColumnName("updated_on");
        }
    }
}
