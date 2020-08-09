using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Plant_Discovery__with_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Plant> plants = new Dictionary<string, Plant>();

            for (int i = 0; i < n; i++)
            {
                string[] plantInfo = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string name = plantInfo[0];
                int rarity = int.Parse(plantInfo[1]);

                if (!plants.ContainsKey(name))
                {

                    plants.Add(name, new Plant());

                    plants[name].Name = name;
                    plants[name].Rarity = rarity;
                    plants[name].Rating = new List<int>();
                }
                else
                {
                    plants[name].Rarity = rarity;
                }
            }

            char[] delimiters = new char[] { ':', '-', ' ' };

            while (true)
            {
                string commandInput = Console.ReadLine();
                if (commandInput == "Exhibition")
                {
                    break;
                }

                string[] command = commandInput.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToArray();

                switch (command[0])
                {
                    case "Rate":

                        string plantToRate = command[1];
                        int rating = int.Parse(command[2]);

                        if (plants.ContainsKey(plantToRate))
                        {
                            plants[plantToRate].Rating.Add(rating);
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }

                        break;

                    case "Update":

                        string plantToUpdate = command[1];
                        int newRarity = int.Parse(command[2]);

                        if (plants.ContainsKey(plantToUpdate))
                        {
                            plants[plantToUpdate].Rarity = newRarity;
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }

                        break;

                    case "Reset":

                        string plantToReset = command[1];

                        if (plants.ContainsKey(plantToReset))
                        {
                            plants[plantToReset].Rating.Clear();
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }


                        break;
                }
            }

            Console.WriteLine("Plants for the exhibition:");

            foreach (var item in plants.OrderByDescending(x => x.Value.Rarity).ThenByDescending(y => y.Value.Rating.Count > 0 ? y.Value.Rating.Average() : 0))
            {
                double averageRating = item.Value.Rating.Count > 0 ? item.Value.Rating.Average() : 0;

                Console.WriteLine($"- {item.Key}; Rarity: {item.Value.Rarity}; Rating: {averageRating:F2}");
            }

        }
    }

    class Plant
    {
        public string Name { get; set; }
        public int Rarity { get; set; }
        public List<int> Rating { get; set; }
    }
}
