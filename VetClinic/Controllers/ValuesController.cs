using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace VetClinic.Controllers
{
    //[Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            using (var db = new VetContext())
            {
                db.Pets.Find(1);
                //model.UserId = Guid.NewGuid();
                //model.Role = 2; //Указываем стандартную роль при регистрации 
                //db.Users.Add(model);//Добавляем модель юзера в собственную бд
                //db.SaveChanges();
            }
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
