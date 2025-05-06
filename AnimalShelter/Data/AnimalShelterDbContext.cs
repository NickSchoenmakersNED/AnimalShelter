using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using AnimalShelter.Classes;

namespace AnimalShelter
{
    public class AnimalShelterDbContext: DbContext
    {
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Cat> Cats { get; set; }
        public DbSet<Dog> Dogs { get; set; }
        public DbSet<Horse> Horses { get; set; }
        public DbSet<HorseType> HorseTypes { get; set; }
        public DbSet<Parrot> Parrots { get; set; }
        public DbSet<Lizard> Lizards { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=AnimalShelterDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var simpleDateConverter = new ValueConverter<SimpleDate, DateTime>(
                v => v.Date,
                v => new SimpleDate(v)
            );

            modelBuilder.Entity<Animal>().Property(a => a.DateOfBirth).HasConversion(simpleDateConverter);
            modelBuilder.Entity<Dog>().Property(d => d.LastWalkDate).HasConversion(simpleDateConverter);

            // Inheritance configuration
            modelBuilder.Entity<Cat>().HasBaseType<Animal>();
            modelBuilder.Entity<Dog>().HasBaseType<Animal>();
            modelBuilder.Entity<Horse>().HasBaseType<Animal>();
            modelBuilder.Entity<Parrot>().HasBaseType<Animal>();
            modelBuilder.Entity<Lizard>().HasBaseType<Animal>();

            // Seed HorseType
            modelBuilder.Entity<HorseType>().HasData(
                new HorseType { Id = 1, Name = "Running" },
                new HorseType { Id = 2, Name = "Cargo" },
                new HorseType { Id = 3, Name = "Sport" },
                new HorseType { Id = 4, Name = "Pet" }
            );
        }
    }
}
