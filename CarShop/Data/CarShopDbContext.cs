using CarShop.Models;
using Microsoft.EntityFrameworkCore;

namespace CarShop.Data
{
    public class CarShopDbContext : DbContext
    {
        public CarShopDbContext(DbContextOptions<CarShopDbContext> options)
           : base(options)
        {
            Database.EnsureCreated();
        }


        public DbSet<Car> Cars { get; set; }
        public DbSet<Make> Makes { get; set; }
        public DbSet<Model> Models { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CarShopDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure relationships between entities
            modelBuilder.Entity<Car>()
                .HasOne(c => c.Make)
                .WithMany(m => m.Models)
                .HasForeignKey(c => c.MakeId)
                .OnDelete(DeleteBehavior.Cascade);

            // Seed initial data
            SeedData(modelBuilder);

            private void SeedData(ModelBuilder modelBuilder)
            { 
            }
            }

    }
}
