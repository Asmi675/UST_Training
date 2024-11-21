using Microsoft.EntityFrameworkCore;
using WebAPICRUD2.Entity;
using WebAPICRUD2.Model;

namespace WebAPICRUD2.Services
{
    public class OurCustomerService : IOurCustomerService
    {
        private readonly OurCustomerDbContext _db;
        public OurCustomerService(OurCustomerDbContext db)
        {
            _db = db;
        }


        public async Task<List<OurCustomer>> GetAllCustomer(bool? isActive)
        {
            if (isActive == null) { return await _db.OurCustomer.ToListAsync(); }

            return await _db.OurCustomer.Where(obj => obj.isActive == isActive).ToListAsync();
        }

        public async Task<OurCustomer?> GetCustomerByID(int id)
        {
            return await _db.OurCustomer.FirstOrDefaultAsync(Customer => Customer.Id == id);
        }

        public async Task<OurCustomer?> AddOurCustomer(AddUpdateCustomer obj)
        {
            var addCustomer = new OurCustomer()
            {
                FirstName = obj.FirstName,
                LastName = obj.LastName,
                isActive = obj.isActive,
            };

            _db.OurCustomer.Add(addCustomer);
            var result = await _db.SaveChangesAsync();
            return result >= 0 ? addCustomer : null;
        }

        public async Task<OurCustomer?> UpdateOurCustomer(int id, AddUpdateCustomer obj)
        {
            var Customer = await _db.OurCustomer.FirstOrDefaultAsync(index => index.Id == id);
            if (Customer != null)
            {
                Customer.FirstName = obj.FirstName;
                Customer.LastName = obj.LastName;
                Customer.isActive = obj.isActive;

                var result = await _db.SaveChangesAsync();
                return result >= 0 ? Customer : null;
            }
            return null;
        }

        public async Task<bool> DeleteCustomerByID(int id)
        {
            var hero = await _db.OurCustomer.FirstOrDefaultAsync(index => index.Id == id);
            if (hero != null)
            {
                _db.OurCustomer.Remove(hero);
                var result = await _db.SaveChangesAsync();
                return result >= 0;
            }
            return false;
        }

    }
}
