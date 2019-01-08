using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel
{
    public class User
    {
        [Key]
        public Guid UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Surname { get; set; }
        public DateTime Birth { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Note { get; set; }
        public string Position { get; set; }
        public int Role { get; set; } // 0-админ; 1 - врач; 2 - пользователь;
        
    }
}
