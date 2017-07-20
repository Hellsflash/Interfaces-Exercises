using System;

public class StartUp
{
    public static void Main(string[] args)
    {
        var phoneNumbers = Console.ReadLine().Split();
        foreach (var phoneNumber in phoneNumbers)
        {
            ICallable phone = new Smartphone();
            Console.WriteLine(phone.Calling(phoneNumber));
        }

        var urls = Console.ReadLine().Split();
        foreach (var url in urls)
        {
            IBrowsable phone = new Smartphone();
            Console.WriteLine(phone.Browsing(url));
        }
    }
}