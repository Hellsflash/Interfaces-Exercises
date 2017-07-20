public class Pet : Inhabitant
{
    public Pet(string name, string birthDate)
    {
        this.Name = name;
        this.Birthdate = birthDate;
    }

    public string Name { get; set; }
}