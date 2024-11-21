using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using sample.Model;

namespace sample.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext _db;
        public ProductRepository(ProductContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Product>> GellAllProduct()
        {
            var product = await _db.Products.ToListAsync();
            return product;
        }

        public async Task<Product> GetProductById(int ProductId)
        {
            var prod = await _db.Products.FirstOrDefaultAsync(pro => pro.ProductId == ProductId);
            return prod;
        }
     

        public async Task<Product> PostProduct(Product product)
        {
            _db.Products.Add(product);
            await _db.SaveChangesAsync();
            return product;
        }

        public async Task<Product> PutProduct(int id,Product product)
        {
            var pr = await _db.Products.FirstOrDefaultAsync(option => option.ProductId==id);
            pr.Name = product.Name;
            pr.Price = product.Price;
            pr.isAvailable = product.isAvailable;
            await _db.SaveChangesAsync();
            return pr;
        }

        public async Task<bool> DeleteProduct(int ProductId)
        {
            var product = await _db.Products.FindAsync(ProductId);
            if (product == null)
            {
                return false;
            }
            _db.Products.Remove(product);
            await _db.SaveChangesAsync();
            return true;
        }

    }
}
