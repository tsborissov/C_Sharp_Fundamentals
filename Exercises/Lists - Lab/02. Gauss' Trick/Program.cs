using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> inputNumbersList = Console.ReadLine().Split().Select(double.Parse).ToList();


            Console.WriteLine(string.Join(" ", GaussTrick(inputNumbersList)));
        }

        static List<double> GaussTrick(List<double> inputNumbersList)
        {
            List<double> result = new List<double>();

            for (int i = 0; i < (inputNumbersList.Count) / 2; i++)
            {
                result.Add(inputNumbersList[i] + inputNumbersList[inputNumbersList.Count - 1 - i]);
            }

            if (inputNumbersList.Count % 2 != 0)
            {
                result.Add(inputNumbersList[inputNumbersList.Count / 2]);
            }

            return result;

        }
    }
}
