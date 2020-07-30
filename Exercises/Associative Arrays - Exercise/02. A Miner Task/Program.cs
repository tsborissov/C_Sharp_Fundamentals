using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> resourcesWithQuantities = new Dictionary<string, int>();

            while (true)
            {
                string resource = Console.ReadLine();

                if (resource == "stop")
                {
                    break;
                }

                int quantity = int.Parse(Console.ReadLine());

                if (resourcesWithQuantities.ContainsKey(resource))
                {
                    resourcesWithQuantities[resource] += quantity;
                }
                else
                {
                    resourcesWithQuantities.Add(resource, quantity);
                }
            }

            foreach (var pair in resourcesWithQuantities)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }

        }
    }
}
