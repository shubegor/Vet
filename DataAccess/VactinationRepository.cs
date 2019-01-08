using System;
using System.Collections.Generic;
using System.Linq;
using DataModel;
namespace DataAccess
{
    public class VactinationRepository : IVactinationRepository
    {
        VetContext vetdb;
        public VactinationRepository()
        {
            this.vetdb = new VetContext();
        }

        public void AddVaccine(Vaccination _v)
        {
            _v.VaccinationId = Guid.NewGuid();
            vetdb.Vaccinations.Add(_v);
            vetdb.SaveChanges();
        }

        public List<Vaccination> GetAllListOfElements()
        {
            List<Vaccination> _all = vetdb.Set<Vaccination>().ToList();
            return _all;
        }

        public void UpdateVaccine(Vaccination _v)
        {
            Vaccination v = vetdb.Vaccinations.Find(_v.VaccinationId);
            v.IsVaccinated = _v.IsVaccinated;
            vetdb.SaveChanges();
        }


    }
}
