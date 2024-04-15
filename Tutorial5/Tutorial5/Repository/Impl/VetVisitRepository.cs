using Tutorial5.Model;

namespace Tutorial5.Repository.Impl;

public class VetVisitRepository : IRepository<VetVisit>
{
    private static AnimalRepository AnimalRepository = new AnimalRepository();

    public static List<VetVisit> VetVisits = new List<VetVisit>()
    {
        new VetVisit(1, new DateTime(2021, 10, 10), AnimalRepository.GetById(0), "Annual checkup", 50.0),
        new VetVisit(2, new DateTime(2021, 10, 11), AnimalRepository.GetById(0), "Vaccination", 30.0),
        new VetVisit(3, new DateTime(2021, 10, 12), AnimalRepository.GetById(1), "Annual checkup", 50.0),
        new VetVisit(4, new DateTime(2021, 10, 13), AnimalRepository.GetById(1), "Vaccination", 30.0),
        new VetVisit(5, new DateTime(2021, 10, 14), AnimalRepository.GetById(2), "Annual checkup", 50.0)
    };

    public List<VetVisit> GetAll()
    {
        return VetVisits;
    }

    public VetVisit GetById(int id)
    {
        return VetVisits.FirstOrDefault(vetVisit => vetVisit.Id == id) ?? throw new Exception("Vet visit not found");
    }

    public List<VetVisit> GetByAnimalId(int animalId)
    {
        return VetVisits.FindAll(vetVisit => vetVisit.Animal.Id == animalId);
    }

    public VetVisit Add(VetVisit vetVisit)
    {
        VetVisits.Add(vetVisit);
        return vetVisit;
    }

    public VetVisit Update(int id, VetVisit vetVisit)
    {
        var index = VetVisits.FindIndex(a => a.Id == id);

        if (index == -1)
        {
            throw new Exception("Vet visit not found");
        }

        VetVisits[index] = vetVisit;
        return vetVisit;
    }

    public VetVisit Delete(int id)
    {
        var vetVisit = VetVisits.FirstOrDefault(a => a.Id == id);

        if (vetVisit == null)
        {
            throw new Exception("Vet visit not found");
        }

        VetVisits.Remove(vetVisit);
        return vetVisit;
    }
}