namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int alder = 17;
            int måneder = 5;
            int stress = -4;
            int resultat;

            resultat = alder + måneder;
            Console.WriteLine($"alder + måneder = {resultat}");
            Console.ReadKey();
            resultat = alder + 7;
            Console.WriteLine($"alder + 7 = {resultat}");
            Console.ReadKey();
            resultat = måneder + 3;
            Console.WriteLine($"måneder + 3 = {resultat}");
            Console.ReadKey();
            resultat = stress - 8;
            Console.WriteLine($"stress - 8 = {resultat}");
            Console.ReadKey();
            resultat = alder + måneder - stress;
            Console.WriteLine($"alder + måneder - stress = {resultat}");
            Console.ReadKey();
        }
    }
}
