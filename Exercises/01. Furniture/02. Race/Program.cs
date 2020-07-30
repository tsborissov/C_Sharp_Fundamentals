using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] participants = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            Dictionary<string, int> participantResults = new Dictionary<string, int>();

            string namePattern = @"[A-Za-z]";
            string distancePattern = @"[0-9]";

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of race") { break; }

                var nameLetters = Regex.Matches(input, namePattern);
                var distanceDigits = Regex.Matches(input, distancePattern);

                string name = String.Concat(nameLetters);
                int distance = distanceDigits.Select(x => int.Parse(x.Value)).Sum();

                if (participants.Contains(name))
                {
                    if (!participantResults.ContainsKey(name))
                    {
                        participantResults.Add(name, distance);
                    }
                    else
                    {
                        participantResults[name] += distance;
                    }
                }
            }

            string[] topParticipants = participantResults.OrderByDescending(x => x.Value).Select(x => x.Key).Take(3).ToArray();

            Console.WriteLine($"1st place: {topParticipants[0]}");

            if (topParticipants.Length > 1)
            {
                Console.WriteLine($"2nd place: {topParticipants[1]}");
            }

            if (topParticipants.Length > 2)
            {
                Console.WriteLine($"3rd place: {topParticipants[2]}");
            }
        }
    }
}
