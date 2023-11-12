using Hs.Models;
using Microsoft.EntityFrameworkCore;

namespace Hs.DatabaseAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Home Interiors", DisplayOrder = 1 },
            new Category { Id = 2, Name = "Clothes & wears", DisplayOrder = 2 },
            new Category { Id = 3, Name = "Computer & tech", DisplayOrder = 3 }
            );

            // base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, pname = "Guitar", pdesc = "This Guiter is electric", price = 1250, brandname = "Ibanez", Quantity = 20},
            new Product { Id = 2, pname = "Piano", pdesc = "This Guiter is from Fender", price = 2550, brandname = "Fender", Quantity = 13 },
            new Product { Id = 3, pname = "Drum", pdesc = "This Guiter is from Gibson Brand, Inc", price = 3450, brandname = "Gibson Brand, Inc", Quantity = 4 }
            );
        }
    }
}