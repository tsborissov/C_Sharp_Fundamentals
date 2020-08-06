using System;
using System.Collections.Generic;
using System.Linq;

namespace Concert_with_Class
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, Band> bands = new Dictionary<string, Band>();

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

                        if (!bands.ContainsKey(bandName))
                        {
                            bands.Add(bandName, new Band());

                            bands[bandName].BandName = bandName;
                            bands[bandName].Members = new List<string>();
                            bands[bandName].PlayTime = 0;

                            AddMembers(bandName, members, bands);
                        }
                        else
                        {
                            AddMembers(bandName, members, bands);
                        }

                        break;

                    case "Play":

                        int playTime = int.Parse(command[2]);

                        if (!bands.ContainsKey(bandName))
                        {
                            bands.Add(bandName, new Band());

                            bands[bandName].BandName = bandName;
                            bands[bandName].Members = new List<string>();
                            bands[bandName].PlayTime = playTime;
                        }
                        else
                        {
                            bands[bandName].PlayTime += playTime;
                        }
                        break;
                }
            }

            int totalPlayTime = bands.Sum(x => x.Value.PlayTime);

            Console.WriteLine($"Total time: {totalPlayTime}");

            foreach (var band in bands.OrderByDescending(x => x.Value.PlayTime).ThenBy(k => k.Key))
            {
                Console.WriteLine($"{band.Key} -> {band.Value.PlayTime}");
            }


            string memebersOfBandToDisplay = Console.ReadLine();

            Console.WriteLine(memebersOfBandToDisplay);

            foreach (var bandMember in bands[memebersOfBandToDisplay].Members)
            {
                Console.WriteLine($"=> {bandMember}");
            }

        }

        static void AddMembers (string bandName, string[] members, Dictionary<string, Band> bands)
        {
            for (int i = 0; i < members.Length; i++)
            {
                if (!bands[bandName].Members.Contains(members[i]))
                {
                    bands[bandName].Members.Add(members[i]);
                }
            }

        }
    }

    class Band
    {
        public string BandName { get; set; }
        public List<string> Members { get; set; }
        public int PlayTime { get; set; }
    }
}
