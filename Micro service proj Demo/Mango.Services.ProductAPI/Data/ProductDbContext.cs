using Mango.Services.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Mango.Services.ProductAPI.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Product { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //adding entries
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1001,
                Name = "Pen",
                Price = 10,
                Description = "Blue Pen",
                CategoryName = "Stationary",
                ImageUrl= "https://th.bing.com/th/id/R.b3a23162bff93129ae5e2a2dc5dcccba?rik=VDbD8YO8zBTEkQ&riu=http%3a%2f%2fnatpen.scene7.com%2fis%2fimage%2fNatPenVegas%2fLNS&ehk=weqJ63x%2fGhajxjBeBcMzyfFeNWN1PBWyFGqhU6D78%2bo%3d&risl=&pid=ImgRaw&r=0",
                ImageLocalPath="D:\\.net\\Pen_image.jpg"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1002,
                Name = "Redmi Phone",
                Price = 25000,
                Description = "C3 Pro",
                CategoryName = "Stationary",
                ImageUrl = "https://images.thequint.com/thequint/2020-02/9e5ba4c9-6a9b-441d-80de-a02a28228182/Realme_C3_1024.webp?rect=0%2C38%2C1024%2C538&w=1200&auto=format%2Ccompress&ogImage=true",
                ImageLocalPath = "D:\\.net\\Phone_image.webp"
            });
        }
    }
}
