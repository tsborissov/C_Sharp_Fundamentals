using System;

namespace _01._National_Court
{
    class Program
    {
        static void Main(string[] args)
        {

            int firstEfficiency = int.Parse(Console.ReadLine());
            int secondEfficiency = int.Parse(Console.ReadLine());
            int thirdEfficiency = int.Parse(Console.ReadLine());
            int peopleCount = int.Parse(Console.ReadLine());

            int efficiencyTotal = firstEfficiency + secondEfficiency + thirdEfficiency;
            int hoursCounter = 0;

            while (peopleCount > 0)
            {
                hoursCounter++;

                if (hoursCounter % 4 == 0)
                {
                    continue;
                }

                peopleCount -= efficiencyTotal;
            }

            Console.WriteLine($"Time needed: {hoursCounter}h.");

        }
    }
}
