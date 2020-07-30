using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements_ver._02
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bestLenght = 0;
            int bestStartIndex = 0;
            int currentLenght = 1;
            int currentStart = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    currentLenght++;
                }
                else
                {
                    currentLenght = 1;
                    currentStart = i;
                }

                if (currentLenght > bestLenght)
                {
                    bestLenght = currentLenght;
                    bestStartIndex = currentStart;
                }
            }

            for (int j = bestStartIndex; j < (bestStartIndex + bestLenght); j++)
            {
                Console.Write(array[j] + " ");
            }

        }
    }
}
