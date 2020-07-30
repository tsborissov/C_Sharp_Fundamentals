using System;
using System.Linq;

namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arrOfRealNumbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            int[] roundedNums = new int[arrOfRealNumbers.Length];

            for (int i = 0; i < arrOfRealNumbers.Length; i++)
            {
                roundedNums[i] = (int)Math.Round(arrOfRealNumbers[i], MidpointRounding.AwayFromZero);
            }

            for (int j = 0; j < arrOfRealNumbers.Length; j++)
            {
                if (arrOfRealNumbers[j] == 0)
                {
                    arrOfRealNumbers[j] = 0;
                }

                Console.WriteLine($"{arrOfRealNumbers[j]} => {roundedNums[j]}");
            }
            
        }
    }
}
