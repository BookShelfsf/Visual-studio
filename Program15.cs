
            Console.WriteLine("Her kan du skrive navn, brugernavn og password");
            Console.ReadKey();

            Console.WriteLine("Skriv navn her");
            string Navn = Console.ReadLine();
            Console.WriteLine("Skriv brugernavn her");
            string brugernavn = Console.ReadLine();
            Console.WriteLine("Skriv pasword her");
            string password = Console.ReadLine();

            string korrektBrugernavn = "LukasHF";
            string korrektPassword = "Homse2008";

            if (brugernavn == korrektBrugernavn && password == korrektPassword)
            {
             Console.WriteLine("Velkommen, " + Navn + "!");
            }
            else
            {   
             Console.WriteLine("Brugernavn eller password er forket");
            }