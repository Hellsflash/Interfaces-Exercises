using System.Linq;

public class Smartphone : IBrowsable, ICallable
{

    public string Browsing(string url)
    {
        if (url.Any(c => char.IsDigit(c)))
        {
            return "Invalid URL!";
        }
        return $"Browsing: {url}!";
    }

    public string Calling(string number)
    {
        if (!number.Any(c => char.IsDigit(c)))
        {
            return "Invalid number!";
        }
        return $"Calling... {number}";
    }
}