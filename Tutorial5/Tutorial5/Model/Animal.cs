namespace Tutorial5.Model;

public class Animal
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Category Category { get; set; }
    public double Weight { get; set; }
    public HairColor HairColor { get; set; }

    public Animal(int id, string name, Category category, double weight, HairColor hairColor)
    {
        Id = id;
        Name = name;
        Category = category;
        Weight = weight;
        HairColor = hairColor;
    }
}