using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Her kan du skrive brugernavn");
        Console.ReadKey();

        string korrektBrugernavn = "LukasHF";
        string korrektPassword = "Homse2008";

        Console.WriteLine("Skriv brugernavn her");
        string brugernavn = Console.ReadLine();

        if (brugernavn == korrektBrugernavn)
        {
            Console.WriteLine("Skriv password her");
            string password = Console.ReadLine();
            if (password == korrektPassword)
            {
                Console.WriteLine("Skriv dit navn her");
                string navn = Console.ReadLine();
                Console.WriteLine("Velkommen, " + navn + "!");
            }
            else
            {
                Console.WriteLine("Passwordet er forkert.");
            }
        }
        else
        {
            Console.WriteLine("Brugernavnet er forkert.");
        }
    }
}
