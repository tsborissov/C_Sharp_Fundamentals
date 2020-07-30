using System;

namespace _10._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {

            int theInteger = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int product = theInteger * i;
                Console.WriteLine($"{theInteger} X {i} = {product}");
            }

        }
    }
}
