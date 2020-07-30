using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {

            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            double result = CalculateFactorial(firstNumber) * 1.0 / CalculateFactorial(secondNumber);

            Console.WriteLine("{0:F2}", result);



        }

        static long CalculateFactorial(int n)
        {
            long factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
