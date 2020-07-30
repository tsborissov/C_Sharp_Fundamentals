using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Messaging
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<char> text = new List<char> (Console.ReadLine());

            int[] elementsSums = new int[numbers.Count];

            for (int i = 0; i < numbers.Count; i++)
            {
                int element = numbers[i];
                int elementSum = 0;

                while (element > 0)
                {
                    elementSum += element % 10;
                    element /= 10;
                }

                elementsSums[i] = elementSum;
            }

            string message = string.Empty;

            for (int j = 0; j < numbers.Count; j++)
            {
                 int index = elementsSums[j];

                if (index > text.Count)
                {
                    index %= text.Count;
                }

                message += text[index];

                text.RemoveAt(index);

            }

            Console.WriteLine(message);

        }
    }
}
