using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Indtast et tal for at udskrive tabellen: ");

        int tal = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{tal} x {i} = {tal * i}");
        }
        Console.ReadKey();
    }
}
