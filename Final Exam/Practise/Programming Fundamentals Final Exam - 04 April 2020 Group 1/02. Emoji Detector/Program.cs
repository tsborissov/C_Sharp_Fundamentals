using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text.RegularExpressions;

namespace _02._Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {

            string emojiMatchPattern = @"(:{2}|\*{2})(?<emoji>[A-Z][a-z]{2,})\1";
            string numberMatchPattern = @"[0-9]";


            string text = Console.ReadLine();


            MatchCollection emojiesCollection = Regex.Matches(text, emojiMatchPattern);

            int countOfAllEmojis = emojiesCollection.Count;


            MatchCollection numbersCollection = Regex.Matches(text, numberMatchPattern);

            int coolThresholdSum = 1;

            foreach (Match number in numbersCollection)
            {
                coolThresholdSum *= int.Parse(number.Value);
            }


            Console.WriteLine($"Cool threshold: {coolThresholdSum}");

            Console.WriteLine($"{countOfAllEmojis} emojis found in the text. The cool ones are:");

            foreach (Match emoji in emojiesCollection)
            {
                int emojiCoolnes = 0;

                string emojiWithoutSeparators = emoji.Groups["emoji"].Value;

                for (int i = 0; i < emojiWithoutSeparators.Length; i++)
                {
                    emojiCoolnes += emojiWithoutSeparators[i];
                }

                if (emojiCoolnes >= coolThresholdSum)
                {
                    Console.WriteLine($"{emoji.Value}");
                }
            }
        }
    }
}
