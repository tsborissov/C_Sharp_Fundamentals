using System;

namespace _10._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {

            int theInteger = int.Parse(Console.ReadLine());

            int times = 1;

            while (times <= 10)
            {
                int product = theInteger * times;
                Console.WriteLine($"{theInteger} X {times} = {product}");
                times++;
            }

        }
    }
}
