using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            int rangeEnd = int.Parse(Console.ReadLine());

            for (int i = 0; i <= rangeEnd; i++)
            {
                if (CheckSumOfDigitsDivision(i) && CheckForOddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }

        }

        static bool CheckSumOfDigitsDivision(int number, int divider = 8)
        {
            bool isDivisible = false;
            int sumOfDigits = 0;

            while (number > 0)
            {
                sumOfDigits += number % 10;
                number /= 10;
            }
            
            if (sumOfDigits % divider == 0)
            {
                isDivisible = true;
            }

            return isDivisible;
        }

        static bool CheckForOddDigit(int number)
        {
            bool isOddDigit = false;

            while (number > 0)
            {
                if ((number % 10) % 2 != 0)
                {
                    isOddDigit = true;
                    break;
                }

                number /= 10;
            }

            return isOddDigit;
        }
    }
}
