using System;
using System.Collections.Generic;
using System.Linq;

namespace Nikulden_s_meals
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> mealsCollection = new Dictionary<string, List<string>>();

            int unlikedMealsCount = 0;


            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Stop")
                {
                    break;
                }

                string command = input.Split('-').ToArray()[0];
                string guest = input.Split('-').ToArray()[1];
                string meal = input.Split('-').ToArray()[2];

                switch (command)
                {
                    case "Like":

                        if (!mealsCollection.ContainsKey(guest))
                        {
                            mealsCollection.Add(guest, new List<string> { meal });
                        }
                        else
                        {
                            if (!mealsCollection[guest].Contains(meal))
                            {
                                mealsCollection[guest].Add(meal);
                            }
                        }

                        break;

                    case "Unlike":

                        if (mealsCollection.ContainsKey(guest))
                        {
                            if (mealsCollection[guest].Contains(meal))
                            {
                                unlikedMealsCount++;
                                mealsCollection[guest].Remove(meal);

                                Console.WriteLine($"{guest} doesn't like the {meal}.");
                            }
                            else
                            {
                                Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                            }
                        }
                        else
                        {
                                Console.WriteLine($"{guest} is not at the party.");
                        }

                        break;
                }
            }

            foreach (var guest in mealsCollection.OrderByDescending(v => v.Value.Count).ThenBy(k => k.Key))
            {
                Console.WriteLine($"{guest.Key}: {string.Join(", ", guest.Value)}");
            }

            Console.WriteLine($"Unliked meals: {unlikedMealsCount}");
        }
    }
}
