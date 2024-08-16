namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tal1 = 42;
            int tal2 = 64;
            int result = tal1 + tal2;

            if (result > 100)
            {
                Console.WriteLine("Summen er over 100");
            }
            else if (result < 100)
            {
                Console.WriteLine("Summen er under 100");
            }
            else if (result == 100)
            {
                Console.WriteLine("summen er 100");
            }
        }
    }
}
