using System;

public class SpecialisedSoldier : Private, ISpecialisedSoldier
{
    private string corp;

    public SpecialisedSoldier(int id, string firstName, string lastName, double salary, string corp) : base(id, firstName, lastName, salary)
    {
        this.Corp = corp;
    }

    public string Corp
    {
        get { return this.corp; }
        set
        {
            if (value != "Airforces" && value != "Marines")
            {
                throw new InvalidOperationException();
            }
            this.corp = value;
        }
    }

    public override string ToString()
    {
        return base.ToString() + Environment.NewLine + "Corps: " + this.Corp;
    }
}