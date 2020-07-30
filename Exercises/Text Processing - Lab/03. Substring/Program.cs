using System;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {

            string stringToRemove = Console.ReadLine();
            string text = Console.ReadLine();

            int indexToRemove = text.IndexOf(stringToRemove);
            int countToRemove = stringToRemove.Length;

            while (indexToRemove != -1)
            {
                text = text.Remove(indexToRemove, countToRemove);
                indexToRemove = text.IndexOf(stringToRemove);
            }

            Console.WriteLine(text);

        }
    }
}
