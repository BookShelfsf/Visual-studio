using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Indtast din indkomst:");
        double indkomst = Convert.ToDouble(Console.ReadLine());
        double skat = 0;

        if (indkomst >= 390000)
        {
            skat += (indkomst * 0.15) + (indkomst * 0.06) + (indkomst * 0.30);
        }
        else if (indkomst >= 280000 && indkomst < 390000)
        {
            skat += (indkomst * 0.06) + (indkomst * 0.30);
        }
        else if (indkomst >= 42000 && indkomst < 280000)
        {
            skat += (indkomst * 0.30);
        }

        Console.WriteLine("Den samlede skat er: " + skat + " kr.");
    }
}
