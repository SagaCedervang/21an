using System;

namespace _21an
{
    class Program
    {
        static void Main(string[] args)
        {
            string menuChoice = "0";
            int maxValue = 11;
            int minValue = 1;

            Random randomCard = new Random();


            Console.WriteLine("Välkommen till 21:an!");
            Console.WriteLine("Välj ett av nedanstående alternativ:");

            while (menuChoice != "4")
            {
                Console.WriteLine("");
                Console.WriteLine("1. Spela 21:an");
                Console.WriteLine("2. Visa senaste vinnaren");
                Console.WriteLine("3. Visa spelreglerna");
                Console.WriteLine("4. Sluta spela");
                menuChoice = Console.ReadLine();


                switch (menuChoice)
                {
                    case "1":
                        // 21:an
                        int playerPoints = 0;
                        int computerPoints = 0;

                        playerPoints = randomCard.Next(minValue, maxValue);
                        Console.WriteLine($"Du har nu {playerPoints} poäng.");

                        break;

                    case "2":
                        // senaste vinnaren
                        break;

                    case "3":
                        // regler
                        Console.WriteLine("Regler till 21:an:");
                        Console.WriteLine("");
                        Console.WriteLine("Ditt mål är att få ett så högt tal som möjligt utan att få ett tal större än 21.");
                        Console.WriteLine("Efter det första kortet är draget kommer du att få ett val om du vill dra ett till eller inte,");
                        Console.WriteLine("svara då 'j' för ja eller 'n' för nej.");
                        Console.WriteLine("När du är klar kommer datorn att köra en omgång förutsat att du inte redan fått 21 och förlorat.");
                        Console.WriteLine("Valörerna på korten växlar mellan 1 och 10.");
                        break;

                    case "4":
                        // avsluta
                        Console.WriteLine("Programmet avslutas...");
                        break;

                    default:
                        // ogiltigt alternativ
                        Console.WriteLine("Du valde inget giltigt alternativ.");
                        Console.WriteLine("Försök igen!");
                        break;
                }
            }
        }
    }
}
