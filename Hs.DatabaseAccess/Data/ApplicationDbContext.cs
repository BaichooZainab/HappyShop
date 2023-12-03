using Hs.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Hs.DatabaseAccess
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Guitars", DisplayOrder = 1 },
            new Category { Id = 2, Name = "Drums", DisplayOrder = 2 },
            new Category { Id = 3, Name = "Piano", DisplayOrder = 3 }
            );

            // base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, Productname = "Guitar", Description = "This Guiter is electric", Prices = 1250, Brandname = "Ibanez", Quantities = 20, CategoryId = 1, ImageUrl = "" },
            new Product { Id = 2, Productname = "Piano", Description = "This piano is from Fender", Prices = 2550, Brandname = "Fender", Quantities = 13, CategoryId = 3, ImageUrl = "" },
            new Product { Id = 3, Productname = "Drum", Description = "This Guiter is from Gibson Brand, Inc", Prices = 3450, Brandname = "Gibson Brand, Inc", Quantities = 4, CategoryId = 2, ImageUrl = "" }
            );
        }
    }
}