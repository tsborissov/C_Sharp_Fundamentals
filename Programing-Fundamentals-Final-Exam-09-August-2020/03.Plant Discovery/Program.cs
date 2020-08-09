using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Plant_Discovery
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<int>>> plants = new Dictionary<string, Dictionary<string, List<int>>>();

            for (int i = 0; i < n; i++)
            {
                string[] plantInfo = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string name = plantInfo[0];
                int rarity = int.Parse(plantInfo[1]);

                if (!plants.ContainsKey(name))
                {

                    plants.Add(name, new Dictionary<string, List<int>>
                    {
                        {"rarity", new List<int>() {rarity}},
                        {"rating", new List<int>()}
                    });

                }
                else
                {
                    plants[name]["rarity"][0] = rarity;
                }
            }

            while (true)
            {
                string commandInput = Console.ReadLine();
                if (commandInput == "Exhibition")
                {
                    break;
                }

                string[] command = commandInput.Split(": ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                switch (command[0])
                {
                    case "Rate":

                        string plantToRate = command[1].Split(" - ", StringSplitOptions.RemoveEmptyEntries).ToArray()[0];
                        int rating = int.Parse(command[1].Split(" - ", StringSplitOptions.RemoveEmptyEntries).ToArray()[1]);

                        if (!plants.ContainsKey(plantToRate))
                        {
                            plants.Add(plantToRate, new Dictionary<string, List<int>>
                            {
                                {"rarity", new List<int>() { 0 } },
                                {"rating", new List<int>() { rating } }
                            });
                        }
                        else
                        {
                            plants[plantToRate]["rating"].Add(rating);
                        }

                        break;

                    case "Update":

                        string plantToUpdate = command[1].Split(" - ", StringSplitOptions.RemoveEmptyEntries).ToArray()[0];
                        int newRarity = int.Parse(command[1].Split(" - ", StringSplitOptions.RemoveEmptyEntries).ToArray()[1]);

                        if (!plants.ContainsKey(plantToUpdate))
                        {

                            plants.Add(plantToUpdate, new Dictionary<string, List<int>>
                            {
                                {"rarity", new List<int>() {newRarity}},
                                {"rating", new List<int>()}
                            });

                        }
                        else
                        {
                            plants[plantToUpdate]["rarity"][0] = newRarity;
                        }

                        break;

                    case "Reset":

                        string plantToReset = command[1];

                        if (plants.ContainsKey(plantToReset))
                        {
                            plants[plantToReset]["rating"].Clear();
                        }
                        

                        break;
                }
            }

            Console.WriteLine("Plants for the exhibition:");

            foreach (var plant in plants.OrderByDescending(x => x.Value["rarity"][0]).ThenByDescending(x => x.Value["rating"].Count > 0 ? x.Value["rating"].Average() : 0.00))
            {
                double ratingAverage = plant.Value["rating"].Count > 0 ? plant.Value["rating"].Average() : 0.00;

                Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value["rarity"][0]}; Rating: {ratingAverage:F2}");
            }

        }
    }
}
