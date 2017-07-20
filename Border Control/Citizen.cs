public class Citizen : Inhabitant
{
    private const int citizenFood = 10;

    public Citizen(string name, int age, string id, string birthDate)
    {

        this.Name = name;
        this.Age = age;
        this.ID = id;
        this.Birthdate = birthDate;
    }

    public override int BuyFood()
    {
        return this.Food = citizenFood;
    }

    public string Name { get; set; }
    public int Age { get; set; }
}