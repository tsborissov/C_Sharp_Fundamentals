using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {

            int yield = int.Parse(Console.ReadLine());

            int totalSpice = 0;
            int daysCounter = 0;

            while (yield >= 100)
            {
                daysCounter++;
                totalSpice += yield;
                yield -= 10;
            }

            totalSpice -= (daysCounter * 26 + 26);

            if (totalSpice < 0)
            {
                totalSpice = 0;
            }

            Console.WriteLine(daysCounter);
            Console.WriteLine(totalSpice);
        }
    }
}
