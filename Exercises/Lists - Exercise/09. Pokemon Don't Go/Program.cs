using System;
using System.Linq;
using System.Collections.Generic;

namespace _09._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> distances = Console.ReadLine().Split().Select(int.Parse).ToList();

            int removedElementsSum = 0;
            int endIndex = distances.Count - 1;

            while (distances.Count > 0)
            {
                int receivedIndex = int.Parse(Console.ReadLine());

                int removedElement = 0;

                if (receivedIndex < 0)
                {
                    removedElement = distances[0];
                    distances[0] = distances[endIndex];
                }
                else if (receivedIndex > endIndex)
                {
                    removedElement = distances[endIndex];
                    distances[endIndex] = distances[0];
                }
                else
                {
                    removedElement = distances[receivedIndex];
                    distances.RemoveAt(receivedIndex);
                    endIndex = distances.Count - 1;
                }

                removedElementsSum += removedElement;


                for (int i = 0; i <= endIndex; i++)
                {
                    if (distances[i] <= removedElement)
                    {
                        distances[i] += removedElement;
                    }
                    else
                    {
                        distances[i] -= removedElement;
                    }
                }

            }

            Console.WriteLine(removedElementsSum);

        }
    }
}
