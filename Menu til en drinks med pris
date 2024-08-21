using System;

class Program
{
    static void Main()
    {
        string[] drinks = { "Isbjørn", "Champagnebrus", "Tequila Sunrise", "Mojito", "Brandbil", "Filur" };
        double[] prices = { 55.00, 45.00, 65.00, 60.00, 50.00, 40.00 };

        Console.WriteLine("Vælg venligst en drink:");

        for (int i = 0; i < drinks.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {drinks[i]} - {prices[i]:C}");
        }

        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice > 0 && choice <= drinks.Length)
        {
            Console.WriteLine($"\nDu har valgt {drinks[choice - 1]} til {prices[choice - 1]:C}.");
        }
        else
        {
            Console.WriteLine("Ugyldigt valg.");
        }
    }
}
