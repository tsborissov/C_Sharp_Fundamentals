using System;
using System.Text;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatString(input, n));


        }

        static string RepeatString(string stringToRepeat, int timesToRepeat)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < timesToRepeat; i++)
            {
                result.Append(stringToRepeat);
            }

            return result.ToString();
        }
    }
}
