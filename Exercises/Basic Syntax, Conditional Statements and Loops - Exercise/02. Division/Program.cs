using System;

namespace _02._Division
{
    class Program
    {
        static void Main(string[] args)
        {

            int input = int.Parse(Console.ReadLine());

            int divider = 0;

            if (input % 10 == 0)
            {
                divider = 10;
            }
            else if (input % 7 == 0)
            {
                divider = 7;
            }
            else if (input % 6 == 0)
            {
                divider = 6;
            }
            else if (input % 3 == 0)
            {
                divider = 3;
            }
            else if (input % 2 == 0)
            {
                divider = 2;
            }

            if (divider != 0)
            {
                Console.WriteLine($"The number is divisible by {divider}");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
