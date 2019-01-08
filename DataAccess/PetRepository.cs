using System.Collections.Generic;
using System.Linq;
using DataModel;



namespace DataAccess
{
    public class PetRepository : IPetRepository
    {
        VetContext vetdb;

        public PetRepository()
        {
            this.vetdb = new VetContext();
        }


        public void AddElements(Pet _pet)
        {
            vetdb.Pets.Add(_pet);
            vetdb.SaveChanges();
        }

        public void DeleteElements(string id)
        {
            var _pet = vetdb.Pets.Find(int.Parse(id));
            vetdb.Pets.Remove(_pet);
            vetdb.SaveChanges();
        }

        public List<Pet> GetAllListOfElements()
        {
            List<Pet> _allPets = vetdb.Set<Pet>().ToList();
            return _allPets;
        }

        public Pet GetElementsById(string id)
        {
            var _pet = vetdb.Pets.Find(int.Parse(id));
            return _pet;
        }

        public void UpdateElements(Pet _pet)
        {
            Pet pet = vetdb.Pets.Find(_pet.PetId);
            pet.Name = _pet.Name;
            pet.Species = _pet.Species;
            pet.Weight = _pet.Weight;
            pet.Gender = _pet.Gender;
            pet.Colour = _pet.Colour;
            pet.Breed = _pet.Breed;
            pet.Birth = _pet.Birth;
            vetdb.SaveChanges();
        }
    }
}
