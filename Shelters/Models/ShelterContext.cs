using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Shelters.Models
{
    public class ShelterContext : DbContext
    {
        public ShelterContext(DbContextOptions<ShelterContext> options)
            : base(options)
        {
        }

        public DbSet<Shelter> Shelters { get; set; }
        public DbSet<ShelterData> ShelterData { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);

      builder.Entity<Shelter>()
          .HasData(
              new Shelter { ShelterId = 1, ShelterName = "Hope" },
              new Shelter { ShelterId = 2, ShelterName = "Life" },
              new Shelter { ShelterId = 3, ShelterName = "Clean the room" },
              new Shelter { ShelterId = 4, ShelterName = "Four paws" },
              new Shelter { ShelterId = 5, ShelterName = "My friend" },
              new Shelter { ShelterId = 6, ShelterName = "Last tear" }
      );
      builder.Entity<ShelterData>()
          .HasData(
              new ShelterData { ShelterDataId = 1, CatsNumber = 4, DogsNumber = 3, ShelterId = 1},
              new ShelterData { ShelterDataId = 2, CatsNumber = 5, DogsNumber = 8, ShelterId = 2},
              new ShelterData { ShelterDataId = 3, CatsNumber = 1, DogsNumber = 7, ShelterId = 3},
              new ShelterData { ShelterDataId = 4, CatsNumber = 17, DogsNumber = 5, ShelterId = 4},
              new ShelterData { ShelterDataId = 5, CatsNumber = 7, DogsNumber = 3, ShelterId = 5},
              new ShelterData { ShelterDataId = 6, CatsNumber = 6, DogsNumber = 10, ShelterId = 6}
      );
    }
    }
}