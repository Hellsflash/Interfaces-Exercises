public class Ferrari : ICar
{
    private string model = "488-Spider";
    private string driver;

    public Ferrari(string driver)
    {

        this.Driver = driver;
    }

    public string Driver
    {
        get { return this.driver; }
        set { this.driver = value; }
    }

    public string PushBreak()
    {
        return "Brakes!";
    }

    public string PushGas()
    {
        return "Zadu6avam sA!";
    }

    public override string ToString()
    {
        return $"{this.model}/{PushBreak()}/{PushGas()}/{this.Driver}";
    }
}