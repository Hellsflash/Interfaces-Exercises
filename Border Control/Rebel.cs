public class Rebel : Inhabitant
{
    private const int rebelFood = 5;

    public Rebel(string name, int age, string group)
    {
        this.Name = name;
        this.Age = age;
        this.Group = group;
    }

    public override int BuyFood()
    {
        return this.Food = rebelFood;
    }

    public string Name { get; set; }
    public int Age { get; set; }
    public string Group { get; set; }
}