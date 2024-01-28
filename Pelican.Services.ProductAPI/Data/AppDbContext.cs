using Pelican.Services.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Pelican.Services.ProductAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Crime and Punishment",
                Price = 25,
                Description = "Fyodor Dostoyevsky",
                ImageUrl = "https://placehold.co/603x403",
                CategoryName = "Crime, Psychology"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "The Little Black Fish",
                Price = 20,
                Description = "Samad Behrangi",
                ImageUrl = "https://placehold.co/602x402",
                CategoryName = "Children's Books"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Also Sprach Zarathustra",
                Price = 30,
                Description = "Friedrich Nietzsche",
                ImageUrl = "https://placehold.co/601x401",
                CategoryName = "Pholosophy"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "The Wuthering Heights",
                Price = 60,
                Description = "Emily Brontë",
                ImageUrl = "https://placehold.co/600x400",
                CategoryName = "Romantic"
            });
        }
    }
}
