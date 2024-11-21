using MicroservicesDemo1.Data;
using MicroservicesDemo1.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroservicesDemo1.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ProductContext _dbContext;

        public CategoryRepository(ProductContext dbContext)

        {

            _dbContext = dbContext;

        }

        public void DeleteCategory(int CategoryId)
        {
            var Category = _dbContext.Categories.Find(CategoryId);

            _dbContext.Categories.Remove(Category);

            Save();
        }

        public Category GetCategoryByID(int CategoryId)
        {
            return _dbContext.Categories.Find(CategoryId);
        }

        public IEnumerable<Category> GetCategory()
        {
            return _dbContext.Categories.ToList();
        }

        public void InsertCategory(Category Category)
        {
            _dbContext.Add(Category);

            Save();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void UpdateCategory(Category Category)
        {
            _dbContext.Entry(Category).State = EntityState.Modified;

            Save();
        }

        Product ICategoryRepository.GetCategoryByID(int Category)
        {
            throw new NotImplementedException();
        }
    }
}
