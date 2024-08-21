namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indtast din alder: ");

            string input = Console.ReadLine();

            int alder;

            // Forsøger at konvertere input til en integer
            if (int.TryParse(input, out alder))
            {
                if (alder > 60)
                {
                    Console.WriteLine("Du er for gammel");
                }
                else if (alder >= 50)
                {
                    Console.WriteLine("Du er hverken for gammel eller for ung");
                }
                else
                {
                    Console.WriteLine("Du er for ung");
                }
            }
            else
            {
                // Hvis input ikke kan konverteres til et heltal, vises en fejlbesked
                Console.WriteLine("Ugyldigt input. Indtast venligst et tal.");
            }
        }
    }
}
