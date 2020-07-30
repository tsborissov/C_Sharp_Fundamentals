using System;
using System.Linq;

namespace _02._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Random myRandom = new Random();

            for (int pos1 = 0; pos1 < words.Length; pos1++)
            {
                int pos2 = myRandom.Next(0, words.Length);

                string temp = words[pos1];
                words[pos1] = words[pos2];
                words[pos2] = temp;
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
