using MicroservicesDemo1.Models;

namespace MicroservicesDemo1.Repository
{
    public interface ICategoryRepository 
    {
        IEnumerable<Category> GetCategory();

        Product GetCategoryByID(int Category);

        void InsertCategory(Category Category);

        void DeleteCategory(int CategoryId);

        void UpdateCategory(Category Category);

        void Save();
    }
}
