using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> listOfArrays = Console.ReadLine().Split('|').ToList();

            List<string> resultList = new List<string>();

            for (int i = listOfArrays.Count - 1; i >= 0; i--)
            {
                List<string> tempList = listOfArrays[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

                for (int j = 0; j < tempList.Count; j++)
                {
                    resultList.Add(tempList[j]);
                }
            }

            
            Console.WriteLine(string.Join(' ', resultList));

        }
    }
}
