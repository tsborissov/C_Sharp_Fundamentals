using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            List<double> inputNumbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            SumAdjacentEqual(inputNumbers);

            Console.WriteLine(string.Join(" ", inputNumbers));

        }

        static void SumAdjacentEqual(List<double> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers.Count - 1 == i)
                {
                    break;
                }

                if (numbers[i] == numbers[i + 1])
                {
                    numbers[i] += numbers[i + 1];

                    numbers.RemoveAt(i + 1);
                    i = -1;
                }

            }
        }
    }
}
