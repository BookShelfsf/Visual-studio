using System.Data;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double beløb = 250.50;
            string indledning = "jeg har";
            string afslutning = "kr. i banken.";
            Console.WriteLine($"{indledning} {beløb} {afslutning}");
            Console.ReadKey();
        }
    }
}
