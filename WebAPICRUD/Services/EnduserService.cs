using Microsoft.AspNetCore.Mvc;
using WebAPICRUD.Model;

namespace WebAPICRUD.Services
{
    public class EnduserService : IEnduserService
    {
        private readonly List<Enduser> _IEnduserList;
        public EnduserService()
        {
            _IEnduserList = new List<Enduser>()
            {
                /*
                new Enduser(){
                Id = 1,
                FirstName = "Test",
                LastName = "",
                isActive = true,
                }
                */
                new Enduser(){Id=1 , FirstName = "Kevin", LastName = "Jober",isActive = true },
                new Enduser(){Id=2 , FirstName = "Asmitha", LastName = "Ragunathan",isActive = true }
            };
        }

        public List<Enduser> GetAllEndusers(bool? isActive)
        {
            return isActive == null ? _IEnduserList : _IEnduserList.Where(User => User.isActive == isActive).ToList();
        }

        public Enduser? GetUserByID(int id)
        {
            return _IEnduserList.FirstOrDefault(User => User.Id == id);
        }

        public Enduser AddUser(AddUpdateEnduser obj)
        {
            var addUser = new Enduser()
            {
                Id = _IEnduserList.Max(User => User.Id) + 1,
                FirstName = obj.FirstName,
                LastName = obj.LastName,
                isActive = obj.isActive,
            };

            _IEnduserList.Add(addUser);

            return addUser;
        }

        public Enduser? UpdateUser(int id, AddUpdateEnduser obj)
        {
            var EnduserIndex = _IEnduserList.FindIndex(index => index.Id == id);
            if (EnduserIndex > 0)
            {
                var User = _IEnduserList[EnduserIndex];

                User.FirstName = obj.FirstName;
                User.LastName = obj.LastName;
                User.isActive = obj.isActive;

                _IEnduserList[EnduserIndex] = User;

                return User;
            }
            else
            {
                return null;
            }
        }
        public bool DeleteUserByID(int id)
        {
            var EnduserIndex = _IEnduserList.FindIndex(index => index.Id == id);
            if (EnduserIndex >= 0)
            {
                _IEnduserList.RemoveAt(EnduserIndex);
            }
            return EnduserIndex >= 0;
        }

    }

    // OurHeroService.cs

    
}
