using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string matchPattern = @"(?<string>[^0-9]+)(?=[0-9])(?<number>[0-9]+)";

            string inputData = Console.ReadLine().ToUpper();

            MatchCollection splitted = Regex.Matches(inputData, matchPattern);

            StringBuilder messageBuilder = new StringBuilder();

            foreach (Match item in splitted)
            {
                string substringToAdd = item.Groups["string"].ToString();

                int count = int.Parse(item.Groups["number"].ToString());

                for (int i = 0; i < count; i++)
                {
                    messageBuilder.Append(substringToAdd);
                }
            }

            string outputMessage = messageBuilder.ToString();

            int uniqueCount = outputMessage.Distinct().Count();

            Console.WriteLine($"Unique symbols used: {uniqueCount}");
            Console.WriteLine(outputMessage);

        }
    }
}
