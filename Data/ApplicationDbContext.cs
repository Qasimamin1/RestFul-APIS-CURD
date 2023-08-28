using Microsoft.EntityFrameworkCore;
using VillaRestFulAPI.Models;

namespace VillaRestFulAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Details = "This villa is available for now",
                    ImageUrl = "https://images.unsplash.com/photo-1586106195724-b1a1e3857559?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80",
                    Occupancy = 5,
                    Rate = 200,
                    Sqft = 500,
                    Amenity = "",
                    CreatedDate = DateTime.Now
                },
                new Villa()
                {
                    Id = 2,
                    Name = "Ocean Villa",
                    Details = "Sea facing beauty",
                    ImageUrl = "https://example.com/oceanvilla.jpg",
                    Occupancy = 4,
                    Rate = 250,
                    Sqft = 550,
                    Amenity = "",
                    CreatedDate = DateTime.Now 
                },
                new Villa()
                {
                    Id = 3,
                    Name = "Mountain Villa",
                    Details = "Mountain view",
                    ImageUrl = "https://example.com/mountainvilla.jpg",
                    Occupancy = 6,
                    Rate = 180,
                    Sqft = 620,
                    Amenity = "",
                    CreatedDate = DateTime.Now
                },
                new Villa()
                {
                    Id = 4,
                    Name = "Urban Villa",
                    Details = "City center location",
                    ImageUrl = "https://example.com/urbanvilla.jpg",
                    Occupancy = 4,
                    Rate = 220,
                    Sqft = 480,
                    Amenity = "",
                    CreatedDate = DateTime.Now
                },
                new Villa()
                {
                    Id = 5,
                    Name = "Desert Villa",
                    Details = "Located in the serene desert",
                    ImageUrl = "https://example.com/desertvilla.jpg",
                    Occupancy = 3,
                    Rate = 210,
                    Sqft = 460,
                    Amenity = "",
                    CreatedDate = DateTime.Now
                }
            );
        }
    }
}
