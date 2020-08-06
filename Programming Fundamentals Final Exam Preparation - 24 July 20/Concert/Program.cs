using System;
using System.Collections.Generic;
using System.Linq;

namespace Concert
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> bandMembers = new Dictionary<string, List<string>>();
            Dictionary<string, int> bandPlayTime = new Dictionary<string, int>();


            while (true)
            {
                string input = Console.ReadLine();
                if (input == "start of concert")
                {
                    break;
                }

                string[] command = input.Split("; ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string bandName = command[1];

                switch (command[0])
                {
                    case "Add":

                        string[] members = command[2].Split(", ", StringSplitOptions.RemoveEmptyEntries);

                        if (!bandMembers.ContainsKey(bandName))
                        {
                            bandMembers.Add(bandName, new List<string>());

                            for (int i = 0; i < members.Length; i++)
                            {
                                if (!bandMembers[bandName].Contains(members[i]))
                                {
                                    bandMembers[bandName].Add(members[i]);
                                }
                            }
                        }
                        else
                        {
                            for (int i = 0; i < members.Length; i++)
                            {
                                if (!bandMembers[bandName].Contains(members[i]))
                                {
                                    bandMembers[bandName].Add(members[i]);
                                }
                            }
                        }

                        if (!bandPlayTime.ContainsKey(bandName))
                        {
                            bandPlayTime.Add(bandName, 0);
                        }

                        break;

                    case "Play":

                        int playTime = int.Parse(command[2]);

                        if (!bandPlayTime.ContainsKey(bandName))
                        {
                            bandPlayTime.Add(bandName, playTime);
                        }
                        else
                        {
                            bandPlayTime[bandName] += playTime;
                        }

                        if (!bandMembers.ContainsKey(bandName))
                        {
                            bandMembers.Add(bandName, new List<string>());
                        }

                        break;
                }
            }

            int totalPlayTime = bandPlayTime.Values.Sum();

            Console.WriteLine($"Total time: {totalPlayTime}");

            foreach (var band in bandPlayTime.OrderByDescending(x => x.Value).ThenBy(k => k.Key))
            {
                Console.WriteLine($"{band.Key} -> {band.Value}");
            }


            string memebersOfBand = Console.ReadLine();

            Console.WriteLine(memebersOfBand);

            foreach (var bandMember in bandMembers[memebersOfBand])
            {
                Console.WriteLine($"=> {bandMember}");
            }
        }
    }
}
