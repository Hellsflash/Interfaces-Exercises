using System;
using System.Text;

public class Spy : Soldier, ISpy
{
    public Spy(int id, string firstName, string lastName, int codeNumber) : base(id, firstName, lastName)
    {
        this.CodeNumber = codeNumber;
    }

    public int CodeNumber { get; set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(base.ToString());
        sb.Append(Environment.NewLine);
        sb.Append($"Code Number:{this.CodeNumber}");
        return sb.ToString();
    }
}