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

            db.Users.Add(new User
            {
                UserId = Guid.NewGuid(),
                Email = "1",
                Birth = DateTime.Now.ToString(),
                Role = 0
            });
        
            base.Seed(db);
        }
    }
}
