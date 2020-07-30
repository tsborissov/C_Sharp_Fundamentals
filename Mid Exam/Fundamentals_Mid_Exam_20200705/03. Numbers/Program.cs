using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbersList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            double averageValue = numbersList.Average();

            var greaterNumbersList = numbersList.FindAll(x => x > averageValue).ToList();
            
            if (greaterNumbersList.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                greaterNumbersList = greaterNumbersList.OrderByDescending(x => x).ToList();

                if (greaterNumbersList.Count > 5)
                {
                    int countToRemove = greaterNumbersList.Count - 5;
                    greaterNumbersList.RemoveRange(5, countToRemove);
                }

                Console.WriteLine(string.Join(' ', greaterNumbersList));
            }
        }
    }
}
