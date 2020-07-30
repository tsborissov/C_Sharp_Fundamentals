using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            var numberOfOccurrences = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if(numberOfOccurrences.ContainsKey(number))
                {
                    numberOfOccurrences[number]++;
                }
                else
                {
                    numberOfOccurrences.Add(number, 1);
                }
            }

            foreach (var item in numberOfOccurrences)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
