using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {

            int firstNumberInput = int.Parse(Console.ReadLine());
            int secondNumberInput = int.Parse(Console.ReadLine());
            int thirdNumberInput = int.Parse(Console.ReadLine());

            Console.WriteLine(SubtractTwoIntegers(SumTwoIntegers(firstNumberInput, secondNumberInput), thirdNumberInput));

        }

        static int SumTwoIntegers(int a, int b)
        {
            return a + b;
        }

        static int SubtractTwoIntegers(int a, int b)
        {
            return a - b;
        }
    }
}
