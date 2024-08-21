using System;

class Program
{
    static void Main()
    {
        int startX = 20;
        int startY = 4;
        int endX = 30;
        int endY = 8;

        for (int x = startX; x <= endX; x++)
        {
            Console.SetCursorPosition(x, startY);
            Console.Write('*');
        }

        for (int x = startX; x <= endX; x++)
        {
            Console.SetCursorPosition(x, endY);
            Console.Write('*');
        }

        for (int y = startY; y <= endY; y++)
        {
            Console.SetCursorPosition(startX, y);
            Console.Write('*');
        }

        for (int y = startY; y <= endY; y++)
        {
            Console.SetCursorPosition(endX, y);
            Console.Write('*');
        }

        Console.ReadKey();
    }
}
