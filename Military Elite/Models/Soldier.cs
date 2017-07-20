using System.ComponentModel;

public abstract class Soldier : ISoldier
{
    public Soldier(int id, string firstName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public override string ToString()
    {
        return $"Name: {this.FirstName} {this.LastName} Id: {this.Id}";
    }
}