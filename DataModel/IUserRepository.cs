using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public interface IUserRepository
    {
        void AddElements(User _user);

        void DeleteElements(string id);
        List<User> GetAllListOfElements();
        List<User> GetDoctorsList();
        List<User> GetDoctorsList(string Position);
        List<User> GetUsersList();
        User GetElementsById(string id);
        void UpdateElements(User _user);
        User GetByEmail(string Email);

    }
}
