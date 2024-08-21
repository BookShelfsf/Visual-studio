using System;

class Program
{
    static void Main()
    {
        Console.Write("Indtast start X-position: ");
        int startX = int.Parse(Console.ReadLine());

        Console.Write("Indtast start Y-position: ");
        int startY = int.Parse(Console.ReadLine());

        Console.Write("Indtast slut X-position: ");
        int endX = int.Parse(Console.ReadLine());

        Console.Write("Indtast slut Y-position: ");
        int endY = int.Parse(Console.ReadLine());

        Console.Write("Indtast dit navn: ");
        string name = Console.ReadLine();

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

        int nameLength = name.Length;

        int centerX = (startX + endX - nameLength) / 2;
        int centerY = (startY + endY) / 2;

        Console.SetCursorPosition(centerX, centerY);
        Console.Write(name);

        Console.ReadKey();
    }
}
