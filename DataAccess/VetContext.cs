using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DataModel;

namespace DataAccess
{
    public class VetContext : DbContext
    {
        public VetContext()
            : base("name=VetContext")
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }
        public DbSet<Vaccination> Vaccinations { get; set; }
    }
}
