using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPours = int.Parse(Console.ReadLine());

            int availableCapacity = 255;

            for (int i = 1; i <= numberOfPours; i++)
            {
                int waterQuantity = int.Parse(Console.ReadLine());

                if (waterQuantity > availableCapacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }

                availableCapacity -= waterQuantity;
            }

            Console.WriteLine(255 - availableCapacity);
        }
    }
}
