using System;
using System.Collections.Generic;
using System.Linq;
using DataModel;
namespace DataAccess
{
    public class UserRepository : IUserRepository
    {
        VetContext vetdb;
        public UserRepository()
        {
            this.vetdb = new VetContext();
        }
        public void AddElements(User _user)
        {
            vetdb.Users.Add(_user);
            vetdb.SaveChanges();
        }

        public void DeleteElements(string id)
        {
            var user = vetdb.Users.Find(new Guid(id));
            vetdb.Users.Remove(user);
            vetdb.SaveChanges();
        }

        public List<User> GetAllListOfElements()
        {
            List<User> _users = vetdb.Set<User>().ToList();
            return _users;
        }
        public List<User> GetDoctorsList()
        {
            List<User> _users = vetdb.Set<User>().Where(x => x.Role == 1).ToList();
            return _users;
        }
        public List<User> GetDoctorsList(string Position)
        {
            List<User> _users = vetdb.Set<User>().Where(x => x.Role == 1).Where(x=> x.Position == Position).ToList();
            return _users;
        }

        public List<User> GetUsersList()
        {
            List<User> _users = vetdb.Set<User>().Where(x => x.Role == 2).ToList();
            return _users;
        }

        public User GetElementsById(string id)
        {
            var _user = vetdb.Users.Find(new Guid(id));
            return _user;
        }

        public void UpdateElements(User _user)
        {
            User user = vetdb.Users.Find(_user.UserId);
            user.Name = _user.Name;
            user.Patronymic = _user.Patronymic;
            user.Surname = _user.Patronymic;
            user.Address = _user.Address;
            user.Birth = _user.Birth;
            user.Note = _user.Note;
            user.PhoneNumber = _user.PhoneNumber;

            vetdb.SaveChanges();
        }

        public User GetByEmail(string Email)
        {
            var _user = vetdb.Users.SingleOrDefault(usr => usr.Email == Email);
            return _user;
        }
    }
}
