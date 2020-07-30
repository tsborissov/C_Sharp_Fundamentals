using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.Mirror_words
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            
            string pattern = @"([#|@])(?<firstWord>[A-Za-z]{3,})\1\1(?<secondWord>[A-Za-z]{3,})\1";

            List<string> mirrorWords = new List<string>();

            MatchCollection mirrorCandidates = Regex.Matches(text, pattern);

            int validPairsCount = mirrorCandidates.Count;

            foreach (Match pair in mirrorCandidates)
            {
                string firstWord = pair.Groups["firstWord"].Value;
                string secondWord = pair.Groups["secondWord"].Value;

                string firstWordReversed = new String(firstWord.ToCharArray().Reverse().ToArray());

                if (secondWord == firstWordReversed)
                {
                    mirrorWords.Add(string.Concat(firstWord, " <=> ", secondWord));
                }

            }

            if (validPairsCount == 0)
            {
                Console.WriteLine("No word pairs found!");

                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine($"{validPairsCount} word pairs found!");

                if (mirrorWords.Count == 0)
                {
                    Console.WriteLine("No mirror words!");
                }
                else
                {
                    Console.WriteLine("The mirror words are:");

                    Console.WriteLine(string.Join(", ", mirrorWords));
                }
            }



        }
    }
}
