using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public interface IVactinationRepository
    {

        void AddVaccine(Vaccination _v);
        List<Vaccination> GetAllListOfElements();
        void UpdateVaccine(Vaccination _v);

    }
}
