using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {

            string action = Console.ReadLine();

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            switch (action)
            {
                case "add": SumTwoNumbers(a, b); break;
                case "multiply": MultiplyTwoNumbers(a, b); break;
                case "subtract": SubtractTwoNumbers(a, b); break;
                case "divide": DivideTwoNumbers(a, b); break;
            }

        }

        static void SumTwoNumbers(int operatorA, int operatorB)
        {
            Console.WriteLine(operatorA + operatorB);
        }

        static void MultiplyTwoNumbers(int operatorA, int operatorB)
        {
            Console.WriteLine(operatorA * operatorB);
        }

        static void SubtractTwoNumbers(int operatorA, int operatorB)
        {
            Console.WriteLine(operatorA - operatorB);
        }

        static void DivideTwoNumbers(int operatorA, int operatorB)
        {
            Console.WriteLine(operatorA / operatorB);
        }
    }
}
