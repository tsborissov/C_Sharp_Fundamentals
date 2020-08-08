using System;
using System.Text.RegularExpressions;

namespace _02.Password
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            string pattern = @"^(.+)>(?<numbers>[0-9]{3})\|(?<lowerLetters>[a-z]{3})\|(?<upperLetters>[A-Z]{3})\|(?<any>[^<^>]{3})<(\1)$";

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if (Regex.IsMatch(input, pattern))
                {
                    string firstPart = Regex.Match(input, pattern).Groups["numbers"].ToString();
                    string secondPart = Regex.Match(input, pattern).Groups["lowerLetters"].ToString();
                    string thirdPart = Regex.Match(input, pattern).Groups["upperLetters"].ToString();
                    string fourthPart = Regex.Match(input, pattern).Groups["any"].ToString();

                    string password = firstPart + secondPart + thirdPart + fourthPart;

                    Console.WriteLine($"Password: {password}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}
