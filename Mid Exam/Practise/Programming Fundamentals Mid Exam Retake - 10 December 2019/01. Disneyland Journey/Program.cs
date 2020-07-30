using System;

namespace _01._Disneyland_Journey
{
    class Program
    {
        static void Main(string[] args)
        {

            double journeyCost = double.Parse(Console.ReadLine());
            int numberOfMonths = int.Parse(Console.ReadLine());

            double savedMoney = 0;

            for (int i = 1; i <= numberOfMonths; i++)
            {
                if (i != 1 && i % 2 != 0)
                {
                    savedMoney -= savedMoney * 0.16;
                }

                if (i % 4 == 0)
                {
                    savedMoney += savedMoney * 0.25;
                }

                savedMoney += journeyCost * 0.25;
            }

            double moneyDiff = savedMoney - journeyCost;

            if (moneyDiff >= 0)
            {
                Console.WriteLine($"Bravo! You can go to Disneyland and you will have {moneyDiff:F2}lv. for souvenirs.");
            }
            else
            {
                Console.WriteLine($"Sorry. You need {Math.Abs(moneyDiff):F2}lv. more.");
            }
        }
    }
}
