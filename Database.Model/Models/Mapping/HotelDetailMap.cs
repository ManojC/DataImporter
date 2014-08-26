using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Database.Model.Models.Mapping
{
    public class HotelDetailMap : EntityTypeConfiguration<HotelDetail>
    {
        public HotelDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.sr);

            // Properties
            this.Property(t => t.sr)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("HotelDetails");
            this.Property(t => t.sr).HasColumnName("sr");
            this.Property(t => t.hotel_name).HasColumnName("hotel_name");
            this.Property(t => t.hotel_code).HasColumnName("hotel_code");
            this.Property(t => t.phone).HasColumnName("phone");
            this.Property(t => t.fax).HasColumnName("fax");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.website).HasColumnName("website");
            this.Property(t => t.chain).HasColumnName("chain");
            this.Property(t => t.check_in).HasColumnName("check_in");
            this.Property(t => t.check_out).HasColumnName("check_out");
            this.Property(t => t.guarantee_policy).HasColumnName("guarantee_policy");
            this.Property(t => t.cancel_policy).HasColumnName("cancel_policy");
            this.Property(t => t.card_accepted).HasColumnName("card_accepted");
            this.Property(t => t.added_by).HasColumnName("added_by");
            this.Property(t => t.added_on).HasColumnName("added_on");
            this.Property(t => t.updated_by).HasColumnName("updated_by");
            this.Property(t => t.updated_on).HasColumnName("updated_on");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.amenities).HasColumnName("amenities");
            this.Property(t => t.existing_id).HasColumnName("existing_id");
            this.Property(t => t.hotel_class).HasColumnName("hotel_class");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.contactperson).HasColumnName("contactperson");
            this.Property(t => t.totnumber).HasColumnName("totnumber");
            this.Property(t => t.approved_by).HasColumnName("approved_by");
            this.Property(t => t.approved_on).HasColumnName("approved_on");
            this.Property(t => t.vendorid).HasColumnName("vendorid");
            this.Property(t => t.appass).HasColumnName("appass");
            this.Property(t => t.expediaid).HasColumnName("expediaid");
        }
    }
}
