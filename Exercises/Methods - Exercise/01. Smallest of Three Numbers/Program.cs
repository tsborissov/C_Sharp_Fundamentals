using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(SmalestOfThreeNumbers(firstNumber, secondNumber, thirdNumber));

        }

        static int SmalestOfThreeNumbers(int a, int b, int c)
        {

            return Math.Min(Math.Min(a, b), c);
        }
    }
}
