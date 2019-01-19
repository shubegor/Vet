using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DataModel;

namespace DataAccess
{
    public class VetDbInitializer : CreateDatabaseIfNotExists<VetContext>//DroporCreateDatabaseIfNotExists<VetContext>
    {
        protected override void Seed(VetContext db)
        {
            string password = "PZBN3ai@";
            var admin = new User { Email = "admin@ya.ru", Password = password, Role = 0 };
            
            db.Users.Add(admin);
            
            db.SaveChanges();
            base.Seed(db);
        }
    }
}
