using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.WriteLine("Indtast et tal mellem 1 og 6:");

        // Læs brugerens input
        string input = Console.ReadLine();

        // Konverter input til en integer, hvis muligt
        if (int.TryParse(input, out int number))
        {
            switch (number)
            {
                case 1:
                case 2:
                case 3:
                case 5:
                case 6:
                    Console.WriteLine($"Du har tastet {number}.");
                    break;

                case 4:
                    // Sæt konsollens tekstfarve til hvid
                    Console.ForegroundColor = ConsoleColor.White;

                    // Beregn midterpositionen
                    int midtX = (Console.WindowWidth / 2) - ("TILLYKKE DU HAR VUNDET".Length / 2);
                    int midtY = Console.WindowHeight / 2;

                    // Sæt cursorpositionen til midten af skærmen
                    Console.SetCursorPosition(midtX, midtY);

                    Console.WriteLine("TILLYKKE DU HAR VUNDET");
                    break;

                default:
                    // Hvis tallet ikke er mellem 1 og 6
                    Console.WriteLine("Du har tastet forkert. Tallet skal være mellem 1 og 6.");
                    // Vent i 10 sekunder og luk programmet
                    Thread.Sleep(10000);
                    return;
            }
        }
        else
        {
            // Hvis input ikke er et gyldigt tal
            Console.WriteLine("Du har tastet forkert. Tallet skal være mellem 1 og 6.");
            // Vent i 10 sekunder og luk programmet
            Thread.Sleep(10000);
            return;
        }
    }
}
