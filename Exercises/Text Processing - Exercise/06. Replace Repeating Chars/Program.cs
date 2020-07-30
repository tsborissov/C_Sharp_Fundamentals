using System;
using System.Text;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();

            StringBuilder result = new StringBuilder(text);

            for (int i = 1; i < result.Length; i++)
            {
                if (result[i] == result [i - 1])
                {
                    result.Remove(i - 1, 1);
                    i--;
                }
            }

            Console.WriteLine(result);
        }
    }
}
