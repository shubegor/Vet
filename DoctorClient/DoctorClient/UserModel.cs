using System;

namespace DoctorClient
{
    public class UserModel
    {
        public Guid UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Surname { get; set; }
        public string Birth { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Note { get; set; }
        public string Position { get; set; }
        public int Role { get; set; }
    }
}