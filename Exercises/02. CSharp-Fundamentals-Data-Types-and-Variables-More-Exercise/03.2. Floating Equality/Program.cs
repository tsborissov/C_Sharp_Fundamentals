using System;

namespace _03._2._Floating_Equality
{
    class Program
    {
        static void Main(string[] args)
        {

            float firstNumber = float.Parse(Console.ReadLine());
            float secondNumber = float.Parse(Console.ReadLine());

            float precision = (float)0.000001;

            bool isEqual = Math.Abs(firstNumber - secondNumber) < precision * firstNumber;

            Console.WriteLine(isEqual);

        }
    }
}
