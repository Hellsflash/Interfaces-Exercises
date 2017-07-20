using System;
using System.Collections.Generic;
using System.Text;

public class Commando : SpecialisedSoldier, ICommando
{
    public Commando(int id, string firstName, string lastName, double salary, string corp) : base(id, firstName, lastName, salary, corp)
    {
        this.Missions = new List<IMission>();
    }

    public List<IMission> Missions { get; set; }

    public void AddMission(IMission mission)
    {
        this.Missions.Add(mission);
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(base.ToString());
        sb.Append("Missions:");
        if (this.Missions.Count > 0)
        {
            sb.AppendLine().Append(string.Join(Environment.NewLine, this.Missions));
        }

        return sb.ToString();
    }
}