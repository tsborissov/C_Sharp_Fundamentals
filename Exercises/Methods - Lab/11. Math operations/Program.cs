using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {

            double inputFirstNumber = double.Parse(Console.ReadLine());
            char inputMathOperator = char.Parse(Console.ReadLine()); // / * + -
            double inputSecondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine(Calculator(inputFirstNumber, inputMathOperator, inputSecondNumber));

        }

        static double Calculator(double firstNumber, char mathOperator, double secondNumber)
        {
            double result = 0;
            
            switch (mathOperator)
            {
                case '/': result = (firstNumber / secondNumber); break;
                case '*': result = (firstNumber * secondNumber); break;
                case '+': result = (firstNumber + secondNumber); break;
                case '-': result = (firstNumber - secondNumber); break;
            }

            return Math.Round(result, 2, MidpointRounding.ToEven);
        }
    }
}
