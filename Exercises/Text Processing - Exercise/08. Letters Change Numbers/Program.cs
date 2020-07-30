using System;
using System.Linq;

namespace _08._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] sequences = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            double totalSum = 0;

            for (int i = 0; i < sequences.Length; i++)
            {

                char firstLetter = sequences[i][0];
                char lastLetter = sequences[i][sequences[i].Length - 1];

                int number = int.Parse(sequences[i].Substring(1, sequences[i].Length - 2));

                int firstLetterPosition = 0;
                int lastLetterPosition = 0;

                double result = 0;

                if (char.IsUpper(firstLetter))
                {
                    firstLetterPosition = firstLetter - 64;
                    result = number * 1.0 / firstLetterPosition;
                }
                else
                {
                    firstLetterPosition = firstLetter - 96;
                    result = number * firstLetterPosition;
                }

                if (char.IsUpper(lastLetter))
                {
                    lastLetterPosition = lastLetter - 64;
                    result -= lastLetterPosition;
                }
                else
                {
                    lastLetterPosition = lastLetter - 96;
                    result += lastLetterPosition;
                }

                totalSum += result;
            }

            Console.WriteLine($"{totalSum:F2}");

        }
    }
}
