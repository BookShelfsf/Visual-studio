﻿Console.WriteLine("Skriv antal km du kører om dagen til og fra arbejde");
double km = double.Parse(Console.ReadLine());

double fradrag = 0;

if (km <= 24)
{
    Console.WriteLine("Du får ikke nok fradrag");
}
else if (km >= 25 && km <=120)
{
fradrag = (km - 24) * 1.93;
Console.WriteLine($"Dit fradrag er: {fradrag} kr.");
}
else if (km > 120)
{
fradrag = (96 * 1.93) + ((km - 120) * 0.97);
    Console.WriteLine($"Dit fradrag er: {fradrag} kr");
}