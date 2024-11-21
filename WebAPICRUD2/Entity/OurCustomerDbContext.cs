using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using WebAPICRUD2.Model;

namespace WebAPICRUD2.Entity
{
    public class OurCustomerDbContext : DbContext
    {
        public OurCustomerDbContext(DbContextOptions<OurCustomerDbContext> options) : base(options)
        {
        }
        // Registered DB Model in OurHeroDbContext file
        public DbSet<OurCustomer> OurCustomer { get; set; }

        /*
         OnModelCreating mainly used to configured our EF model
         And insert master data if required
        */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Setting a primary key in OurHero model
            modelBuilder.Entity<OurCustomer>().HasKey(x => x.Id);

            // Inserting record in OurHero table
            modelBuilder.Entity<OurCustomer>().HasData(
                new OurCustomer
                {
                    Id = 1,
                    FirstName = "System",
                    LastName = "",
                    isActive = true,
                }
            );
        }
    }
}
