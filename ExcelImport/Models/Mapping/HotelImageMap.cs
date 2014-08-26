using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ExcelImport.Models.Mapping
{
    public class HotelImageMap : EntityTypeConfiguration<HotelImage>
    {
        public HotelImageMap()
        {
            // Primary Key
            this.HasKey(t => new { t.sr, t.hotel_id });

            // Properties
            this.Property(t => t.sr)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.hotel_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("HotelImage");
            this.Property(t => t.sr).HasColumnName("sr");
            this.Property(t => t.hotel_id).HasColumnName("hotel_id");
            this.Property(t => t.thumb_url).HasColumnName("thumb-url");
            this.Property(t => t.full_url).HasColumnName("full-url");
            this.Property(t => t.image_category).HasColumnName("image-category");
            this.Property(t => t.image_caption).HasColumnName("image-caption");
            this.Property(t => t.added_by).HasColumnName("added_by");
            this.Property(t => t.added_on).HasColumnName("added_on");
            this.Property(t => t.updated_by).HasColumnName("updated_by");
            this.Property(t => t.updated_on).HasColumnName("updated_on");
        }
    }
}
