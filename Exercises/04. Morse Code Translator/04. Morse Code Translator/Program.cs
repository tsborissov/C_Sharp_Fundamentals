using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04._Morse_Code_Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, char> morseCode = new Dictionary<string, char>()
            {
                {".-", 'A'},
                {"-...", 'B'},
                {"-.-.", 'C'},
                {"-..", 'D'},
                {".", 'E'},
                {"..-.", 'F'},
                {"--.", 'G'},
                {"....", 'H'},
                {"..", 'I'},
                {".---", 'J'},
                {"-.-", 'K'},
                {".-..", 'L'},
                {"--", 'M'},
                {"-.", 'N'},
                {"---", 'O'},
                {".--.", 'P'},
                {"--.-", 'Q'},
                {".-.", 'R'},
                {"...", 'S'},
                {"-", 'T'},
                {"..-", 'U'},
                {"...-", 'V'},
                {".--", 'W'},
                {"-..-", 'X'},
                {"-.--", 'Y'},
                {"--..", 'Z'},
                {"|", ' '}
            };

            string[] inputMorseCode = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < inputMorseCode.Length; i++)
            {
                string currentMorseCharacter = inputMorseCode[i];

                char currentChar = morseCode[currentMorseCharacter];

                sb.Append(currentChar);
            }

            Console.WriteLine(sb);
        }
    }
}
