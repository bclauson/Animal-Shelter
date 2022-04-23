using Microsoft.EntityFrameworkCore;

namespace LocalAnimalShelter.Models
{
    public class LocalAnimalShelterContext : DbContext
    {
        public LocalAnimalShelterContext(DbContextOptions<LocalAnimalShelterContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Animal>()
              .HasData(
                  new Animal { AnimalId = 1, Name = "Joey", Species = "Cat", Age = 2, Gender = "Male" },
                  new Animal { AnimalId = 2, Name = "Max", Species = "Dog", Age = 5, Gender = "Male" },
                  new Animal { AnimalId = 3, Name = "Aquarius", Species = "Cat", Age = 3, Gender = "Female" },
                  new Animal { AnimalId = 4, Name = "Sadie", Species = "Dog", Age = 4, Gender = "Female" },
                  new Animal { AnimalId = 5, Name = "Rex", Species = "Dog", Age = 3, Gender = "Male" },
                  new Animal { AnimalId = 6, Name = "Sally", Species = "Dog", Age = 1, Gender = "Female" },
                  new Animal { AnimalId = 7, Name = "Lex", Species = "Cat", Age = 2, Gender = "Female" }
              );
        }

        public DbSet<Animal> Animals { get; set; }
    }
}