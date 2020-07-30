using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            string pattern = @"\+(?<=[^| ])359([ \-])2\1[0-9]{3}\1[0-9]{4}(?![0-9])";

            string phones = Console.ReadLine();

            MatchCollection phoneMatches = Regex.Matches(phones, pattern);

            //var matchedPhones = phoneMatches.Cast<Match>()
            //    .Select(x => x.Value.Trim())
            //    .ToArray();

            //Console.WriteLine(string.Join(", ", matchedPhones));

            Console.WriteLine(string.Join(", ", phoneMatches));

        }
    }
}
