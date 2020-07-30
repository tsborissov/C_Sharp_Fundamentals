using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] words = Console.ReadLine().Split().ToArray();

            Dictionary<string, int> numberOfOccurrences = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string lowerWord = word.ToLower();

                if(numberOfOccurrences.ContainsKey(lowerWord))
                {
                    numberOfOccurrences[lowerWord]++;
                }
                else
                {
                    numberOfOccurrences.Add(lowerWord, 1);
                }
            }

            foreach (var word in numberOfOccurrences)
            {
                if (word.Value % 2 != 0)
                {
                    Console.Write(word.Key + " ");
                }
            }

        }
    }
}
