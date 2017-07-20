using System;
using System.Collections.Generic;

public class StarUp
{
    public static void Main(string[] args)
    {
        var inhabitants = new Dictionary<string, Inhabitant>();
        var totalFood = 0;
        var inputNum = int.Parse(Console.ReadLine());

        for (int i = 0; i < inputNum; i++)
        {
            var inputArgs = Console.ReadLine().Split();

            if (inputArgs.Length == 4)
            {
                inhabitants.Add(inputArgs[0], new Citizen(inputArgs[0], int.Parse(inputArgs[1]), inputArgs[2], inputArgs[3]));
            }
            else
            {
                inhabitants.Add(inputArgs[0], new Rebel(inputArgs[0], int.Parse(inputArgs[1]), inputArgs[2]));
            }
        }
        var input = Console.ReadLine();
        while (input != "End")
        {

            if (inhabitants.ContainsKey(input))
            {

                totalFood += inhabitants[input].BuyFood();
            }

            input = Console.ReadLine();
        }

        Console.WriteLine(totalFood);
    }
}