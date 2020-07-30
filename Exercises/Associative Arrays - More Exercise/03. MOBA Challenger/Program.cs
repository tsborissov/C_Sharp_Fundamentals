using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._MOBA_Challenger
{
    class Program
    {
        static void Main(string[] args)
        {

            // {player} -> {position} -> {skill}
            // {player} vs {player}

            Dictionary<string, Dictionary<string, int>> playerPool = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Season end") { break; }

                string[] commandSplitted = input.Split().ToArray();

                switch (commandSplitted[1])
                {
                    case "->":

                        string player = commandSplitted[0];
                        string position = commandSplitted[2];
                        int skill = int.Parse(commandSplitted[4]);

                        if (!playerPool.ContainsKey(player))
                        {
                            playerPool.Add(player, new Dictionary<string, int>());

                            playerPool[player].Add(position, skill);
                        }
                        else
                        {
                            if (!playerPool[player].ContainsKey(position))
                            {
                                playerPool[player].Add(position, skill);
                            }
                            else
                            {
                                if (playerPool[player][position] < skill)
                                {
                                    playerPool[player][position] = skill;
                                }
                            }
                        }

                        break;

                    case "vs":



                        break;
                }

            }

            foreach (var pair in playerPool)
            {
                Console.WriteLine($"{pair.Key}: {} skill");

                foreach (var item in pair.Value.OrderByDescending(skill => skill.Value))
                {
                    Console.WriteLine($"- {item.Key} <::> {item.Value}");
                }
            }

        }
    }
}
