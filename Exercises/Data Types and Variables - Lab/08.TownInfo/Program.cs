﻿using System;

namespace _08.TownInfo
{
    class Program
    {
        static void Main(string[] args)
        {

            string townName = Console.ReadLine();
            uint population = uint.Parse(Console.ReadLine());
            uint area = uint.Parse(Console.ReadLine());

            Console.WriteLine($"Town {townName} has population of {population} and area {area} square km.");
        }
    }
}
