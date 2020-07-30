using System;
using System.Runtime.Serialization;

namespace _1._Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {

            int energy = int.Parse(Console.ReadLine());

            int successCounter = 0;

            string input;
            while((input = Console.ReadLine()) != "End of battle")
            {
                int distance = int.Parse(input);

                if (energy - distance >= 0)
                {
                    successCounter++;
                    energy -= distance;

                    if (successCounter % 3 == 0)
                    {
                        energy += successCounter;
                    }
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {successCounter} won battles and {energy} energy");
                    energy -= distance;
                    break;
                }
            }

            if (energy >= 0)
            {
                Console.WriteLine($"Won battles: {successCounter}. Energy left: {energy}");
            }



        }
    }
}
