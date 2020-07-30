using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bombNumberAndPower = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bombNumber = bombNumberAndPower[0];
            int power = bombNumberAndPower[1];


            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombNumber)
                {
                    int startIndex = i - power;
                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }

                    int endIndex = i + power;
                    if (endIndex > numbers.Count - 1)
                    {
                        endIndex = numbers.Count - 1;
                    }

                    int countToRemove = endIndex - startIndex + 1;

                    numbers.RemoveRange(startIndex, countToRemove);

                    i = -1;
                }
            }

            Console.WriteLine(numbers.Sum());

        }
    }
}
