﻿using System;
using System.Reflection;

public class StartUp
{
    public static void Main(string[] args)
    {
        Type identifiableInterface = typeof(Citizen).GetInterface("IIdentifiable");
        Type birthableInterface = typeof(Citizen).GetInterface("IBirthable");
        PropertyInfo[] properties = identifiableInterface.GetProperties();
        Console.WriteLine(properties.Length);
        Console.WriteLine(properties[0].PropertyType.Name);
        properties = birthableInterface.GetProperties();
        Console.WriteLine(properties.Length);
        Console.WriteLine(properties[0].PropertyType.Name);
        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
    }
}