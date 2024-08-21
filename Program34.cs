int i = 1;

while (i <= 10)
{
    int resultat = i * 4;

    if (resultat == 16)
    {
        i++;
        continue;
    }

    Console.WriteLine(resultat);
    i++;
}

Console.WriteLine("Loopen er nu stoppet.");
Console.ReadKey();
