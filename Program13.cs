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
                if (alder > 57)
                {
                    Console.WriteLine("Du er for gammel");
                }
                else if (alder < 57)
                {
                    Console.WriteLine("Du er ikke for gammel");
                }
                else
                {
                    Console.WriteLine("Du er præcis 57 år gammel");
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
