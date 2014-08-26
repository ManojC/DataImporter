using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Database.Model.Models.Mapping;

namespace Database.Model.Models
{
    public partial class AkbarTravelsDbContext : DbContext
    {
        static AkbarTravelsDbContext()
        {
            Database.SetInitializer<AkbarTravelsDbContext>(null);
        }

        public AkbarTravelsDbContext()
            : base("Name=AkbarTravelsDbContext")
        {
        }

        public DbSet<HotelDetail> HotelDetails { get; set; }
        public DbSet<Rate> Rates { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new HotelDetailMap());
            modelBuilder.Configurations.Add(new RateMap());
        }
    }
}
