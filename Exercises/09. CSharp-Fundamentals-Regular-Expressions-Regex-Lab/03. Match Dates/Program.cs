using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {

            string pattern = @"(?<day>\d\d)([.\-\/])(?<month>[A-Z][a-z]{2})\1(?<year>[0-9]{4})";
            //set our backreference from \2 to \1. This is because C# backreferences don’t count named capture groups for backreferences!

            string input = Console.ReadLine();

            MatchCollection dates = Regex.Matches(input, pattern);

            foreach (Match date in dates)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }

        }
    }
}
