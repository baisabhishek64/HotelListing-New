using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.data
{
    public class HotelListingDbContext: DbContext
    {
        public HotelListingDbContext(DbContextOptions options): base(options)
        {
                
        }

        public DbSet<Hotel> Hotels { get; set; }

        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "India",
                    ShortName = "IND",
                },
                new Country
                {
                    Id = 2,
                    Name = "America",
                    ShortName = "USA"
                }
            );
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "TAJ Hotels",
                    CountryId = 1,
                    Address = "Mumbai",
                    Rateing = 4.5
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Cherries",
                    CountryId = 2,
                    Address = "Newyork",
                    Rateing = 4
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Grand Hayyat",
                    CountryId = 1,
                    Address = "Goa",
                    Rateing = 4.1
                },
                new Hotel
                {
                    Id = 4,
                    Name = "Welcome",
                    CountryId = 2,
                    Address = "Los Angeles",
                    Rateing = 4.4
                }
            );
        }
    }
}
