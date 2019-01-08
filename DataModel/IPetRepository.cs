using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public interface IPetRepository 
    {    
         void AddElements(Pet _pet);
         void DeleteElements(string id);
         List<Pet> GetAllListOfElements();
         Pet GetElementsById(string id);
         void UpdateElements(Pet _pet);
    }
}
