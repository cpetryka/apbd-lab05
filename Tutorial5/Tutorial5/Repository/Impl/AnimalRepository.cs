using Tutorial5.Model;

namespace Tutorial5.Database;

public class AnimalRepository : IRepository<Animal>
{
    public static List<Animal> animals = new List<Animal>()
    {
        new Animal(1, "Azor", Category.DOG, 2, HairColor.BLACK),
        new Animal(2, "Filemon", Category.CAT, 1.5, HairColor.WHITE),
        new Animal(3, "Mruczek", Category.CAT, 2.5, HairColor.BROWN),
        new Animal(4, "Burek", Category.DOG, 3, HairColor.BROWN),
        new Animal(5, "Puszek", Category.CAT, 1, HairColor.WHITE),
        new Animal(6, "Reksio", Category.DOG, 4, HairColor.BLACK),
    };

    public List<Animal> GetAll()
    {
        return animals;
    }

    public Animal GetById(int id)
    {
        return animals.FirstOrDefault(animal => animal.Id == id) ?? throw new Exception("Animal not found");
    }

    public Animal Add(Animal animal)
    {
        animals.Add(animal);
        return animal;
    }

    public Animal Update(int id, Animal animal)
    {
        var index = animals.FindIndex(a => a.Id == id);

        if (index == -1)
        {
            throw new Exception("Animal not found");
        }

        animals[index] = animal;
        return animal;
    }

    public Animal Delete(int id)
    {
        var animal = animals.FirstOrDefault(a => a.Id == id);

        if (animal == null)
        {
            throw new Exception("Animal not found");
        }

        animals.Remove(animal);
        return animal;
    }
}