using System;

namespace _02._Ascii_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {

            char startChar = char.Parse(Console.ReadLine());
            char endChar = char.Parse(Console.ReadLine());

            string text = Console.ReadLine();

            int sum = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];
                
                if (currentChar > startChar && currentChar < endChar)
                {
                    sum += currentChar;
                }

            }

            Console.WriteLine(sum);
        }
    }
}
