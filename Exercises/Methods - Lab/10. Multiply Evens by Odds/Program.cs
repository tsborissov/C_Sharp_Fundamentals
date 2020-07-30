using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {

            int inputNumber = Math.Abs(int.Parse(Console.ReadLine()));

            Console.WriteLine(GetMultipleOfEvenAndOdds(GetSumOfEvenDigits(inputNumber), GetSumOfOddDigits(inputNumber)));

        }

        static int GetMultipleOfEvenAndOdds(int evenSum, int oddSum)
        {
            int result = evenSum * oddSum;

            return result;
        }

        static int GetSumOfEvenDigits(int number)
        {
            int evenSum = 0;

            while(number > 0)
            {
                int digit = number % 10;
                if (digit % 2 == 0)
                {
                    evenSum += digit;
                }
                number /= 10;
            }

            return evenSum;
        }

        static int GetSumOfOddDigits(int number)
        {
            int oddSum = 0;

            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 != 0)
                {
                    oddSum += digit;
                }
                number /= 10;
            }

            return oddSum;
        }

    }
}
