using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {

            string matchPattern = @"(?<=(\=|\/))[A-Z][a-z]{2,}(?=\1)";

            string input = Console.ReadLine();

            int travelPoints = 0;

            MatchCollection locations = Regex.Matches(input, matchPattern);

            foreach (Match location in locations)
            {
                travelPoints += location.Length;
            }

            Console.WriteLine($"Destinations: {string.Join(", ", locations)}");
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}
