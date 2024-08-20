using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.Title = "Festen";

        Console.WriteLine("Hvilken farve foretrækker du? (rød, grøn, blå, gul): ");
        string farve = Console.ReadLine().ToLower();

        Console.WriteLine("Hvad er din alder? ");
        string alderInput = Console.ReadLine();

        int alder = int.Parse(alderInput);

        if (farve == "rød")
        {
            Console.BackgroundColor = ConsoleColor.Red;
        }
        else if (farve == "grøn")
        {
            Console.BackgroundColor = ConsoleColor.Green;
        }
        else if (farve == "blå")
        {
            Console.BackgroundColor = ConsoleColor.Blue;
        }
        else if (farve == "gul")
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
        }

        Console.Clear();

        if (alder > 18)
        {
            Console.WriteLine("Velkommen til cocktailbaren.");
        }
        else
        {
            Console.WriteLine("Velkommen til sodavandsbaren.");
        }

        Thread.Sleep(10000);
        Console.ResetColor();
    }
}
