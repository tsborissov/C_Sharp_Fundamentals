using System;
using System.Linq;

namespace _03._Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] neighborhood = Console.ReadLine()
                .Split('@')
                .Select(int.Parse)
                .ToArray();

            int houseIndex = 0;

            string input = string.Empty;
            while((input = Console.ReadLine()) != "Love!")
            {
                string[] command = input.Split().ToArray();

                int jumpLength = int.Parse(command[1]);

                houseIndex += jumpLength;

                if (houseIndex > neighborhood.Length - 1)
                {
                    houseIndex = 0;
                }

                if (neighborhood[houseIndex] == 0)
                {
                    Console.WriteLine($"Place {houseIndex} already had Valentine's day.");
                }
                else
                {
                    neighborhood[houseIndex] -= 2;
                    if (neighborhood[houseIndex] == 0)
                    {
                        Console.WriteLine($"Place {houseIndex} has Valentine's day.");
                    }
                }
            }

            Console.WriteLine($"Cupid's last position was {houseIndex}.");

            if (neighborhood.All(x => x == 0))
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                int houseCount = neighborhood.Where(x => x > 0).Count();
                
                Console.WriteLine($"Cupid has failed {houseCount} places.");
            }
        }
    }
}
