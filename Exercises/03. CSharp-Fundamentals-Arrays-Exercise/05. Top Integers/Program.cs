using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arrOfIntegers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < arrOfIntegers.Length; i++)
            {

                bool isTopInteger = true;

                for (int j = i + 1; j < arrOfIntegers.Length; j++)
                {

                    if (arrOfIntegers[i] <= arrOfIntegers[j])
                    {
                        isTopInteger = false;
                        break;
                    }
                }

                if (isTopInteger)
                {
                    Console.Write(arrOfIntegers[i] + " ");
                }
            }
        }
    }
}
