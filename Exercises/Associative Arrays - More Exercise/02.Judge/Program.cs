using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> contestsRegistered = new Dictionary<string, Dictionary<string, int>>(); // contest, username, points

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "no more time") { break; }

                string username = input.Split(" -> ")[0];
                string contest = input.Split(" -> ")[1];
                int points = int.Parse(input.Split(" -> ")[2]);

                if (!contestsRegistered.ContainsKey(contest))
                {
                    contestsRegistered.Add(contest, new Dictionary<string, int>());
                    contestsRegistered[contest].Add(username, points);
                }
                else
                {
                    if (!contestsRegistered[contest].ContainsKey(username))
                    {
                        contestsRegistered[contest].Add(username, points);
                    }
                    else
                    {
                        if (contestsRegistered[contest][username] < points)
                        {
                            contestsRegistered[contest][username] = points;
                        }
                    }
                }

            }

            foreach (var contest in contestsRegistered)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");

                int rowNr = 1;

                foreach (var user in contest.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{rowNr++}. {user.Key} <::> {user.Value}");
                }
            }

            Dictionary<string, int> userTotalPoints = new Dictionary<string, int>(); // username, total points

            foreach (var contest in contestsRegistered)
            {
                foreach (var user in contest.Value)
                {
                    if(!userTotalPoints.ContainsKey(user.Key))
                    {
                        userTotalPoints.Add(user.Key, user.Value);
                    }
                    else
                    {
                        userTotalPoints[user.Key] += user.Value;
                    }
                }
            }

            Console.WriteLine("Individual standings: ");

            int rowNo = 1;

            foreach (var pair in userTotalPoints.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{rowNo++}. {pair.Key} -> {pair.Value}");
            }


        }
    }
}
