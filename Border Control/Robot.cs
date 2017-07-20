public class Robot : Inhabitant
{
    public Robot(string model, string id)
    {
        this.Model = model;
        this.ID = id;
    }

    public string Model { get; set; }
}