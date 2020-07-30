using System;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberInput = int.Parse(Console.ReadLine());

            PrintNxNmatrix(numberInput);
        }

        static void PrintNxNmatrix(int n)
        {
            for (int row = 1; row <= n; row++)
            {
                for (int column = 1; column <= n; column++)
                {
                    Console.Write(n + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
