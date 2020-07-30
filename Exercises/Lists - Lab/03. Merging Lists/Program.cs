using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {

            List<double> firstListInput = Console.ReadLine().Split().Select(double.Parse).ToList();
            List<double> secondListInput = Console.ReadLine().Split().Select(double.Parse).ToList();

            Console.WriteLine(string.Join(" ", MergeTwoLists(firstListInput, secondListInput)));
        }

        static List<double> MergeTwoLists(List <double> firstList, List<double> secondList)
        {
            List<double> result = new List<double>();
            int workingCount = 0;

            if (firstList.Count >= secondList.Count)
            {
                workingCount = firstList.Count;
            }
            else
            {
                workingCount = secondList.Count;
            }

            for (int i = 0; i < workingCount; i++)
            {
                if (i < firstList.Count)
                {
                    result.Add(firstList[i]);
                }

                if (i < secondList.Count)
                {
                    result.Add(secondList[i]);
                }
            }

            return result;
        }
    }
}
