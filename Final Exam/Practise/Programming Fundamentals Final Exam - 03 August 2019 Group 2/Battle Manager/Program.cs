using System;
using System.Collections.Generic;
using System.Linq;

namespace Battle_Manager
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, Dictionary<string, int>> battleBook = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Results")
                {
                    break;
                }

                string[] command = input.Split(':').ToArray();

                switch (command[0])
                {
                    case"Add":
                        //Add:{personName}:{health}:{energy}

                        string personName = command[1];
                        int health = int.Parse(command[2]);
                        int energy = int.Parse(command[3]);

                        if (!battleBook.ContainsKey(personName))
                        {
                            battleBook.Add(personName, new Dictionary<string, int>
                            {
                                {"health", health },
                                {"energy", energy }
                            });
                        }
                        else
                        {
                            battleBook[personName]["health"] += health;
                        }
                        break;

                    case "Attack":
                        // Attack:{attackerName}:{defenderName}:{damage}

                        string attackerName = command[1];
                        string defenderName = command[2];
                        int damage = int.Parse(command[3]);

                        if (battleBook.ContainsKey(attackerName) && battleBook.ContainsKey(defenderName))
                        {
                            battleBook[defenderName]["health"] -= damage;

                            if (battleBook[defenderName]["health"] < 1)
                            {
                                battleBook.Remove(defenderName);

                                Console.WriteLine($"{defenderName} was disqualified!");
                            }

                            battleBook[attackerName]["energy"] -= 1;

                            if (battleBook[attackerName]["energy"] < 1)
                            {
                                battleBook.Remove(attackerName);

                                Console.WriteLine($"{attackerName} was disqualified!");
                            }
                        }

                        break;

                    case "Delete":

                        string name = command[1];

                        if (name == "All")
                        {
                            battleBook.Clear();
                        }
                        else
                        {
                            battleBook.Remove(name);
                        }

                        break;
                }
            }

            Console.WriteLine($"People count: {battleBook.Count}");

            foreach (var person in battleBook.OrderByDescending(x => x.Value["health"]).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{person.Key} - {person.Value["health"]} - {person.Value["energy"]}");
            }

        }
    }
}
