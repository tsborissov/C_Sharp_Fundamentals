using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {

            string valuesType = Console.ReadLine(); //int, char or string
            string inputValueA = Console.ReadLine();
            string inputValueB = Console.ReadLine();

            switch (valuesType)
            {
                case "int": Console.WriteLine(GetMax(int.Parse(inputValueA), int.Parse(inputValueB))); break;
                case "char": Console.WriteLine(GetMax(char.Parse(inputValueA), char.Parse(inputValueB))); break;
                case "string": Console.WriteLine(GetMax(inputValueA, inputValueB)); break;
            }

            
        }

        static int GetMax(int valueA, int valueB)
        {

            if (valueA.CompareTo(valueB) > 0)
            {
                return valueA;
            }
            else
            {
                return valueB;
            }
        }

        static char GetMax(char valueA, char valueB)
        {

            if (valueA.CompareTo(valueB) > 0)
            {
                return valueA;
            }
            else
            {
                return valueB;
            }
        }

        static string GetMax(string valueA, string valueB)
        {

            if (valueA.CompareTo(valueB) > 0)
            {
                return valueA;
            }
            else
            {
                return valueB;
            }
        }
    }
}
