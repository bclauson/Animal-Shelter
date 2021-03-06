// <auto-generated />
using LocalAnimalShelter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LocalAnimalShelter.Migrations
{
    [DbContext(typeof(LocalAnimalShelterContext))]
    [Migration("20220423210408_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("LocalAnimalShelter.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Species")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Age = 2,
                            Gender = "Male",
                            Name = "Joey",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 2,
                            Age = 5,
                            Gender = "Male",
                            Name = "Max",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 3,
                            Age = 3,
                            Gender = "Female",
                            Name = "Aquarius",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 4,
                            Age = 4,
                            Gender = "Female",
                            Name = "Sadie",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 5,
                            Age = 3,
                            Gender = "Male",
                            Name = "Rex",
                            Species = "Dog"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
