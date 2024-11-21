using WebAPICRUD.Model;

namespace WebAPICRUD.Services
{
    public interface IEnduserService
        {
            List<Enduser> GetAllEndusers(bool? isActive);

            Enduser? GetUserByID(int id);

            Enduser AddUser(AddUpdateEnduser obj);

            Enduser? UpdateUser(int id, AddUpdateEnduser obj);

            bool DeleteUserByID(int id);
        }
}
