using sample.Model;

namespace sample.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GellAllProduct();
        Task<Product> GetProductById(int ProductId );
        Task<Product>  PutProduct(int id,Product product );
        Task<Product> PostProduct(Product product );
        Task<bool> DeleteProduct (int ProductId );
    }
}
