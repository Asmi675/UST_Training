using WebAPICRUD2.Model;

namespace WebAPICRUD2.Services
{
    public interface IOurCustomerService
    {
        Task<List<OurCustomer>> GetAllCustomer(bool? isActive);
        Task<OurCustomer?> GetCustomerByID(int id);
        Task<OurCustomer?> AddOurCustomer(AddUpdateCustomer obj);
        Task<OurCustomer?> UpdateOurCustomer(int id, AddUpdateCustomer obj);
        Task<bool> DeleteCustomerByID(int id);
    }
}