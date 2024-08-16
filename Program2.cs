namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast dit navn");
            string navn = Console.ReadLine();

            Console.Write("Indtast din alder");
            int alder = int.Parse(Console.ReadLine());
            Console.WriteLine($"jeg hedder {navn}, og er {alder} år gammel");
            Console.ReadKey();
        }
    }
}
