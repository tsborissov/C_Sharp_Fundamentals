using System;
using System.Linq;

namespace _04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrOfStrings = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < arrOfStrings.Length / 2; i++)
            {
                string temp = arrOfStrings[i];
                arrOfStrings[i] = arrOfStrings[arrOfStrings.Length - i - 1];
                arrOfStrings[arrOfStrings.Length - i - 1] = temp;
            }

            Console.WriteLine(string.Join(" ", arrOfStrings));

        }
    }
}
