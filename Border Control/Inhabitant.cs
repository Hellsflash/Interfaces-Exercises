public abstract class Inhabitant : IIdentifiable, IBirthable, IBuyer
{
    public string ID { get; set; }
    public string Birthdate { get; set; }
    public int Food { get; set; }

    public virtual int BuyFood()
    {
        return this.Food;
    }
}