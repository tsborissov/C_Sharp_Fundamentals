using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputString = Console.ReadLine();

            Dictionary<char, int> charactersCount = new Dictionary<char, int>();

            for (int i = 0; i < inputString.Length; i++)
            {
                char currentCharacter = inputString[i];

                if (currentCharacter == ' ')
                {
                    continue;
                }
                

                if (charactersCount.ContainsKey(currentCharacter))
                {
                    charactersCount[currentCharacter]++;
                }
                else
                {
                    charactersCount.Add(currentCharacter, 1);
                }
            }

            // charactersCount.Remove(' ');

            foreach (var character in charactersCount)
            {
                Console.WriteLine($"{character.Key} -> {character.Value}");
            }
        }
    }
}
