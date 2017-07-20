using System;
using System.Collections.Generic;
using System.Text;

public class LeutenantGeneral : Private, ILeutenantGeneral
{
    public LeutenantGeneral(int id, string firstName, string lastName, double salary) : base(id, firstName, lastName, salary)
    {
        this.Privates = new List<IPrivate>();
    }

    public List<IPrivate> Privates { get; set; }

    public void AddPrivates(IPrivate newPrivate)
    {
        this.Privates.Add(newPrivate);
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder(base.ToString());
        sb.AppendLine().AppendLine($"Privates:");
        if (this.Privates.Count > 0)
        {
            sb.AppendLine("  " + string.Join(Environment.NewLine + "  ", this.Privates));
        }
        return sb.ToString();
    }
}