using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
            keyMaterials.Add("shards", 0);
            keyMaterials.Add("fragments", 0);
            keyMaterials.Add("motes", 0);

            SortedDictionary<string, int> junkMaterials = new SortedDictionary<string, int>();

            string legendaryItem = string.Empty;
            bool isLegendaryItemCollected = false;

                        
            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                for (int i = 0; i < input.Length; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i + 1].ToLower();

                    if (material == "shards" || material == "fragments" || material == "motes")
                    {
                        if (keyMaterials.ContainsKey(material))
                        {
                            keyMaterials[material] += quantity;
                        }
                        else
                        {
                            keyMaterials.Add(material, quantity);
                        }
                    }
                    else
                    {
                        if (junkMaterials.ContainsKey(material))
                        {
                            junkMaterials[material] += quantity;
                        }
                        else
                        {
                            junkMaterials.Add(material, quantity);
                        }
                    }

                    if (keyMaterials.ContainsKey("shards") && keyMaterials["shards"] >= 250)
                    {
                        keyMaterials["shards"] -= 250;
                        legendaryItem = "Shadowmourne";
                        isLegendaryItemCollected = true;
                        break;
                    }


                    if (keyMaterials.ContainsKey("fragments") && keyMaterials["fragments"] >= 250)
                    {
                        keyMaterials["fragments"] -= 250;
                        legendaryItem = "Valanyr";
                        isLegendaryItemCollected = true;
                        break;
                    }

                    if (keyMaterials.ContainsKey("motes") && keyMaterials["motes"] >= 250)
                    {
                        keyMaterials["motes"] -= 250;
                        legendaryItem = "Dragonwrath";
                        isLegendaryItemCollected = true;
                        break;
                    }
                }

                if (isLegendaryItemCollected)
                { 
                    break;
                }

            }

            keyMaterials = keyMaterials.OrderByDescending(pair => pair.Value).ThenBy(pair => pair.Key).ToDictionary(pair => pair.Key, pair => pair.Value);

            Console.WriteLine($"{legendaryItem} obtained!");

            foreach (var item in keyMaterials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in junkMaterials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }
    }
}
