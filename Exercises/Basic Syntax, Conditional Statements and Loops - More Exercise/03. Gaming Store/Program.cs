using System;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {

            double initialBallance = double.Parse(Console.ReadLine());

            double price = 0;
            double moneySpent = 0;
            string nameOfGame = String.Empty;


            while ((nameOfGame = Console.ReadLine()) != "Game Time")
            {
                switch (nameOfGame)
                {
                    case "OutFall 4": price = 39.99; break;
                    case "CS: OG": price = 15.99; break;
                    case "Zplinter Zell": price = 19.99; break;
                    case "Honored 2": price = 59.99; break;
                    case "RoverWatch": price = 29.99; break;
                    case "RoverWatch Origins Edition": price = 39.99; break;
                    default: Console.WriteLine("Not Found"); price = 0; break;
                }

                if (price > initialBallance - moneySpent)
                {
                    Console.WriteLine("Too Expensive");
                    continue;
                }

                if (price != 0)
                {
                    Console.WriteLine($"Bought {nameOfGame}");
                    moneySpent += price;

                }

                if (initialBallance - moneySpent <= 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
            }

            if (initialBallance - moneySpent > 0)
            {
                Console.WriteLine($"Total spent: ${moneySpent:F2}. Remaining: ${(initialBallance - moneySpent):F2}");

            }

        }
    }
}
