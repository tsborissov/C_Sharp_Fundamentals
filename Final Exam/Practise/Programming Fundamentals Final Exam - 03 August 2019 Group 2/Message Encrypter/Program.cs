using System;
using System.Text.RegularExpressions;

namespace Message_Encrypter
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            string pattern = @"([*@])(?<tag>[A-Z][a-z]{2,})\1:\s\[(?<firstGroup>[A-Za-z]{1})\]\|\[(?<secondGroup>[A-Za-z]{1})\]\|\[(?<thirdGroup>[A-Za-z]{1})\]\|$";

            for (int i = 0; i < n; i++)
            {
                string message = Console.ReadLine();

                if (!Regex.IsMatch(message, pattern))
                {
                    Console.WriteLine("Valid message not found!");
                }
                else
                {
                    string tag = Regex.Match(message, pattern).Groups["tag"].ToString();
                    int firstNumber = char.Parse(Regex.Match(message, pattern).Groups["firstGroup"].ToString());
                    int secondNumber = char.Parse(Regex.Match(message, pattern).Groups["secondGroup"].ToString());
                    int thirdNumber = char.Parse(Regex.Match(message, pattern).Groups["thirdGroup"].ToString());

                    Console.WriteLine($"{tag}: {firstNumber} {secondNumber} {thirdNumber}");
                }
            }
        }
    }
}
