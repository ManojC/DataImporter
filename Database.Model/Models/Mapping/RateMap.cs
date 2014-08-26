using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Database.Model.Models.Mapping
{
    public class RateMap : EntityTypeConfiguration<Rate>
    {
        public RateMap()
        {
            // Primary Key
            this.HasKey(t => new { t.sr, t.hotel_id });

            // Properties
            this.Property(t => t.sr)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.hotel_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Rates");
            this.Property(t => t.sr).HasColumnName("sr");
            this.Property(t => t.hotel_id).HasColumnName("hotel_id");
            this.Property(t => t.room_type).HasColumnName("room_type");
            this.Property(t => t.room_category).HasColumnName("room_category");
            this.Property(t => t.room_description).HasColumnName("room_description");
            this.Property(t => t.room_type_code).HasColumnName("room_type_code");
            this.Property(t => t.inclusion).HasColumnName("inclusion");
            this.Property(t => t.amount).HasColumnName("amount");
            this.Property(t => t.currency).HasColumnName("currency");
            this.Property(t => t.rack_rate).HasColumnName("rack_rate");
            this.Property(t => t.valid_from).HasColumnName("valid_from");
            this.Property(t => t.valid_till).HasColumnName("valid_till");
            this.Property(t => t.tax).HasColumnName("tax");
            this.Property(t => t.rate_disclaimer).HasColumnName("rate_disclaimer");
            this.Property(t => t.added_by).HasColumnName("added_by");
            this.Property(t => t.added_on).HasColumnName("added_on");
            this.Property(t => t.updated_by).HasColumnName("updated_by");
            this.Property(t => t.updated_on).HasColumnName("updated_on");
            this.Property(t => t.allocations).HasColumnName("allocations");
            this.Property(t => t.max_guest).HasColumnName("max_guest");
            this.Property(t => t.max_adult).HasColumnName("max_adult");
            this.Property(t => t.max_child).HasColumnName("max_child");
            this.Property(t => t.min_adult).HasColumnName("min_adult");
            this.Property(t => t.min_child).HasColumnName("min_child");
            this.Property(t => t.extra_adult).HasColumnName("extra_adult");
            this.Property(t => t.extra_child).HasColumnName("extra_child");
            this.Property(t => t.display_rate).HasColumnName("display_rate");
            this.Property(t => t.nights).HasColumnName("nights");
            this.Property(t => t.stat).HasColumnName("stat");
            this.Property(t => t.valdays).HasColumnName("valdays");
        }
    }
}
