using System;

namespace _04._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOfLines = int.Parse(Console.ReadLine());

            int asciiCodesSum = 0;

            for (int i = 1; i <= numberOfLines; i++)
            {
                char inputChar = char.Parse(Console.ReadLine());

                asciiCodesSum += inputChar;
            }

            Console.WriteLine($"The sum equals: {asciiCodesSum}");

        }
    }
}
