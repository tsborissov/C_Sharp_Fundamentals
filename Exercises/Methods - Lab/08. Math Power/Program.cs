using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {

            double numberInput = double.Parse(Console.ReadLine());
            int powerInput = int.Parse(Console.ReadLine());

            Console.WriteLine(RaiseToPower(numberInput, powerInput));

        }

        static double RaiseToPower(double number, int power)
        {
            double result = Math.Pow(number, power);

            return result;
        }
    }
}
