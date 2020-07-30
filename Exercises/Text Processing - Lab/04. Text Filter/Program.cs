using System;
using System.Linq;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] bannedWords = Console.ReadLine().Split(", ").ToArray();

            string text = Console.ReadLine();

            foreach (var bannedWord in bannedWords)
            {
                string banMask = new string('*', bannedWord.Length);

                text = text.Replace(bannedWord, banMask);
            }

            Console.WriteLine(text);
        }
    }
}
