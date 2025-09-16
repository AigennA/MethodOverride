
using System;

class Program
{
    //Metod 1: Format namn med för- och efternamn
    static string FormatName(string first, string last)
    {
        return $"{first} {last}";
    }

    //Metod 2: Format namn med för-, mellan- och efternamn
    static string FormatName(string first, string middle, string last)
    {
        return $"{first} {middle} {last}";
    }

    //Metod 3: Formatnamn med möjlighet att göra det versalt
    static string FormatName(string first, string last, bool uppercase)
    {
        var full = $"{first} {last}";
        return uppercase ? full.ToUpper() : full;
    }

    static void Main(string[] args)
    {
        // Anrop alla tre metoder
        Console.WriteLine(FormatName("Maria", "Johansson"));
        Console.WriteLine(FormatName("Maria", "Eva", "Johansson"));
        Console.WriteLine(FormatName("Maria", "Johansson", true));
    }
}