using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace sample.Model
{
    public class ProductContext:DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options) { }
        
        public DbSet<Product> Products { get; set; }
    }
}
