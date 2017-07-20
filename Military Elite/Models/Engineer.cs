using System;
using System.Collections.Generic;
using System.Text;

public class Engineer : SpecialisedSoldier, IEngineer
{
    public Engineer(int id, string firstName, string lastName, double salary, string corp) : base(id, firstName, lastName, salary, corp)
    {
        this.Repairs = new List<IRepair>();
    }

    public List<IRepair> Repairs { get; set; }

    public void AddRepair(Repair repair)
    {
        this.Repairs.Add(repair);
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine(base.ToString());
        sb.Append("Repairs:");
        if (this.Repairs.Count > 0)
        {
            sb.AppendLine().Append(string.Join(Environment.NewLine, this.Repairs));
        }
        return sb.ToString();
    }
}