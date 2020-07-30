using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int sumFactorial = 0;


            for (int i = 0; i <= input.Length - 1; i++)
            {
                // int digit = input[i] - '0';
                int digit = int.Parse(input[i].ToString());
                int Factorial = 1;

                for (int j = 1; j <= digit; j++)
                {
                    Factorial *= j;
                }

                sumFactorial += Factorial;
            }

            if (int.Parse(input) == sumFactorial)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
