using System;
using System.Text.RegularExpressions;

namespace _02.Boss_Rush
{
    class Program
    {
        static void Main(string[] args)
        {

            string pattern = @"\|(?<boss>[A-Z]{4,})\|:#(?<title>[A-Za-z]+ [A-Za-z]+)#";

            int numberOfInputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfInputs; i++)
            {
                string input = Console.ReadLine();

                if (Regex.IsMatch(input, pattern))
                {
                    string name = Regex.Match(input, pattern).Groups["boss"].ToString();
                    string title = Regex.Match(input, pattern).Groups["title"].ToString();

                    Console.WriteLine($"{name}, The {title}");
                    Console.WriteLine($">> Strength: {name.Length}");
                    Console.WriteLine($">> Armour: {title.Length}");
                }
                else
                {
                    Console.WriteLine("Access denied!");
                }
            }

        }
    }
}
