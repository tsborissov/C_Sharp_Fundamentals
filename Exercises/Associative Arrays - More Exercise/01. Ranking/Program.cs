using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> contestPasswords = new Dictionary<string, string>();

            while (true)
            {
                string contestInput = Console.ReadLine();
                if (contestInput == "end of contests") { break; }

                string contest = contestInput.Split(':')[0];
                string contestPassword = contestInput.Split(':')[1];

                if (!contestPasswords.ContainsKey(contest))
                {
                    contestPasswords.Add(contest, contestPassword);
                }
                else
                {
                    contestPasswords[contest] = contestPassword;
                }
            }


            SortedDictionary<string, Dictionary<string, int>> contestResults = new SortedDictionary<string, Dictionary<string, int>>();  // username, contest name, points

            while (true)
            {
                string interviewInput = Console.ReadLine();
                if(interviewInput == "end of submissions") { break; }

                string interviewContest = interviewInput.Split("=>")[0];
                string interviewPassword = interviewInput.Split("=>")[1];
                string username = interviewInput.Split("=>")[2];
                int points = int.Parse(interviewInput.Split("=>")[3]);

                if (!contestPasswords.ContainsKey(interviewContest) || contestPasswords[interviewContest] != interviewPassword)
                {
                    continue;
                }

                if (!contestResults.ContainsKey(username))
                {
                    contestResults.Add(username, new Dictionary<string, int>());

                    contestResults[username].Add(interviewContest, points);
                }
                else
                {
                    if(!contestResults[username].ContainsKey(interviewContest))
                    {
                        contestResults[username].Add(interviewContest, points);
                    }
                    else
                    {
                        if((contestResults[username])[interviewContest] < points)
                        {
                            (contestResults[username])[interviewContest] = points;
                        }
                    }
                }
            }


            string bestCandidate = string.Empty;
            int bestPoints = 0;

            foreach (var pair in contestResults)
            {
                int totalPoints = 0;

                foreach (var item in pair.Value)
                {
                    totalPoints += item.Value;
                }

                if (totalPoints > bestPoints)
                {
                    bestPoints = totalPoints;
                    bestCandidate = pair.Key;
                }
            }

            Console.WriteLine($"Best candidate is {bestCandidate} with total {bestPoints} points.");

            Console.WriteLine("Ranking: ");

            foreach (var pair in contestResults)
            {
                Console.WriteLine(pair.Key);

                foreach (var item in pair.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {item.Key} -> {item.Value}");
                }
            }
        }
    }
}
