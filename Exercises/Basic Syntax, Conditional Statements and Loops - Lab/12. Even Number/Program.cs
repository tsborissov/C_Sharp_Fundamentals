﻿using System;

namespace _12._Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            while ((number = int.Parse(Console.ReadLine())) % 2 != 0)
            {
                Console.WriteLine("Please write an even number.");
            }

            Console.WriteLine($"The number is: {Math.Abs(number)}");
        }
    }
}
