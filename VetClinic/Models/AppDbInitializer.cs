using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace VetClinic.Models
{
    public class AppDbInitializer : CreateDatabaseIfNotExists<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            var userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(context));

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            
            var role1 = new IdentityRole { Name = "admin" };
            

            // добавляем роли в бд
            roleManager.Create(role1);
           

            // создаем пользователей
            string password = "PZBN3ai@";
            var admin = new ApplicationUser { Email = "admin@ya.ru" , UserName = "admin@ya.ru" };
            
            var result1 = userManager.Create(admin, password);
            

            // если создание пользователя прошло успешно
            if (result1.Succeeded)
            {
                userManager.AddToRole(admin.Id, role1.Name);
            }
            

            base.Seed(context);
        }
    }
}