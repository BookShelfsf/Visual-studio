using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Indtast antal km du kører til og fra arbejde: ");
        int distance = int.Parse(Console.ReadLine());

        double fradrag = 0;

        if (distance <= 24)
        {
            fradrag = 0;
        }
        else if ((distance > 24 && distance <= 100) || (distance > 100 && distance <= 100))
        {
            fradrag = (distance - 24) * 1.54;
        }
        else if (distance > 100)
        {
            fradrag = (100 - 24) * 1.54 + (distance - 100) * 0.77;
        }

        Console.WriteLine("Dit samlede befordringsfradrag er: " + fradrag + " kr.");
        Console.ReadKey();
    }
}
