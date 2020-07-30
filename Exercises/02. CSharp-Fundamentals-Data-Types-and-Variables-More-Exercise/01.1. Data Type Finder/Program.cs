using System;

namespace _01._1._Data_Type_Finder
{
    class Program
    {
        static void Main(string[] args)
        {

            string userInput = String.Empty;

            while ((userInput = Console.ReadLine()) != "END")
            {
                bool isInteger = int.TryParse(userInput, out int outInt);
                bool isFloat = float.TryParse(userInput, out float outFloat);
                bool isChar = char.TryParse(userInput, out char outChar);
                bool isBool = bool.TryParse(userInput, out bool outBool);
                
                if (isInteger)
                {
                    Console.WriteLine($"{userInput} is integer type");
                }
                else if (isFloat)
                {
                    Console.WriteLine($"{userInput} is floating point type");
                }
                else if (isChar)
                {
                    Console.WriteLine($"{userInput} is character type");
                }
                else if (isBool)
                {
                    Console.WriteLine($"{userInput} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{userInput} is string type");
                }

            }

        }
    }
}
