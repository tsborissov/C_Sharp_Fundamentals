using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> biggestThreeNumbers = Console.ReadLine().Split()
                .Select(int.Parse)
                .OrderByDescending(number => number)
                .Take(3)
                .ToList();

            Console.WriteLine(string.Join(" ", biggestThreeNumbers));

        }
    }
}
