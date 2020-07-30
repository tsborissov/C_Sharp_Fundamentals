using System;

namespace _04.RefactoringPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int endOfRange = int.Parse(Console.ReadLine());
            for (int number = 2; number <= endOfRange; number++)
            {
                bool isPrime = true;
                for (int divider = 2; divider < number; divider++)
                {
                    if (number % divider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine("{0} -> {1}", number, isPrime.ToString().ToLower());
            }
        }
    }
}
