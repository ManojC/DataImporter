using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using ExcelImport.Models.Mapping;

namespace ExcelImport.Models
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
        public DbSet<HotelImage> HotelImages { get; set; }
        public DbSet<HotelLocationInfo> HotelLocationInfoes { get; set; }
        public DbSet<HotelNearBy> HotelNearBies { get; set; }
        public DbSet<HotelRating> HotelRatings { get; set; }
        public DbSet<Rate> Rates { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new HotelDetailMap());
            modelBuilder.Configurations.Add(new HotelImageMap());
            modelBuilder.Configurations.Add(new HotelLocationInfoMap());
            modelBuilder.Configurations.Add(new HotelNearByMap());
            modelBuilder.Configurations.Add(new HotelRatingMap());
            modelBuilder.Configurations.Add(new RateMap());
        }
    }
}
