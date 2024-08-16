using System;

namespace VariabelEksempel
{
    class Program
    {
        static void Main(string[] args)
        {
            int var1 = 10;
            int var2 = 20;

            bool erVar1StørreEndVar2 = var1 > var2;

            Console.WriteLine($"Er var1 større end var2? {erVar1StørreEndVar2}");
            Console.ReadKey();
            var1 = 30;
            
            erVar1StørreEndVar2 = var1 > var2;
            Console.WriteLine($"Er var1 større end var2? {erVar1StørreEndVar2}");
            Console.ReadKey ();
        }
    }
}
