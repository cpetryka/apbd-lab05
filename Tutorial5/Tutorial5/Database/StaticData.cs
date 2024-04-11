using Tutorial5.Model;

namespace Tutorial5.Database;

public class StaticData
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
}