using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.Post_Office
{
    class Program
    {
        static void Main(string[] args)
        {

            string capitalLettersPattern = @"[.]*([#$%&])(?<capitals>[A-Z]+)\1[.]*";
            string codeLengthPattern = @"(?<code>\d{2}):(?<length>\d{2})";
            string wordsPattern = @"(?<=\s|^)[A-Z][\S]*";

            List<string> validWords = new List<string>();
            Dictionary<char, int> capitalsLenghts = new Dictionary<char, int>();

            string input = Console.ReadLine();

            string firstPart = input.Split('|').ToArray()[0];
            string secondPart = input.Split('|').ToArray()[1];
            string thirdPart = input.Split('|').ToArray()[2];
            
            string capitalLetters = Regex.Match(firstPart, capitalLettersPattern).Groups["capitals"].ToString();

            MatchCollection codesLengths = Regex.Matches(secondPart, codeLengthPattern);

            foreach (Match code in codesLengths)
            {
                int charCode = int.Parse(code.Groups["code"].ToString());
                int wordLength = int.Parse(code.Groups["length"].ToString()) + 1;

                if (charCode >= 65 && charCode <= 90)
                {
                    for (int i = 0; i < capitalLetters.Length; i++)
                    {
                        if (capitalLetters[i] == charCode)
                        {
                            if (!capitalsLenghts.ContainsKey(capitalLetters[i]))
                            {
                                capitalsLenghts.Add(capitalLetters[i], wordLength);
                            }
                        }
                    }
                }
            }

            MatchCollection words = Regex.Matches(thirdPart, wordsPattern);

            foreach (Match word in words)
            {
                if (capitalsLenghts.ContainsKey(word.ToString()[0]) && word.ToString().Length == capitalsLenghts[word.ToString()[0]])
                {
                    validWords.Add(word.ToString());
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, validWords));

        }
    }
}
