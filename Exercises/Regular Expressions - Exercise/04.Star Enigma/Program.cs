using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _04.Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            string decryptPattern = @"[starSTAR]";

            string messagePattern = @"(?<=\@)(?<name>[A-Za-z]+)[^\@\-\!\:\>]*\:(?<population>[0-9]+)[^\@\-\!\:\>]*!(?<type>[AD])![^\@\-\!\:\>]*->(?<soldierCount>[0-9]+)";

            Dictionary<string, List<string>> planets = new Dictionary<string, List<string>>();

            planets.Add("attacked", new List<string>());
            planets.Add("destroyed", new List<string>());


            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string encryptedMessage = Console.ReadLine();

                int key = Regex.Matches(encryptedMessage, decryptPattern).Count;

                string decriptedMessage = string.Empty;

                for (int j = 0; j < encryptedMessage.Length; j++)
                {
                    decriptedMessage += (char)(encryptedMessage[j] - key);
                }

                if (Regex.IsMatch(decriptedMessage, messagePattern))
                {
                    string planetName = Regex.Match(decriptedMessage, messagePattern).Groups["name"].ToString();
                    string attackType = Regex.Match(decriptedMessage, messagePattern).Groups["type"].ToString();

                    if (attackType == "A")
                    {
                        planets["attacked"].Add(planetName);
                    }
                    else
                    {
                        planets["destroyed"].Add(planetName);
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {planets["attacked"].Count}");

            foreach (var planet in planets["attacked"].OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }


            Console.WriteLine($"Destroyed planets: {planets["destroyed"].Count}");

            foreach (var planet in planets["destroyed"].OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
