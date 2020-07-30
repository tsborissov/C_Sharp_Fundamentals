using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Hero_Recruitment
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<string>> heroesSpellbook = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }


                string[] command = input.Split().ToArray();

                string heroName = command[1];
                string spellName = string.Empty;

                switch (command[0])
                {
                    case "Enroll":

                        if (!heroesSpellbook.ContainsKey(heroName))
                        {
                            heroesSpellbook.Add(heroName, new List<string>());
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} is already enrolled.");
                        }

                        break;

                    case "Learn":
                        
                        spellName = command[2];

                        if (!heroesSpellbook.ContainsKey(heroName))
                        {
                            Console.WriteLine($"{heroName} doesn't exist.");
                        }
                        else
                        {
                            if (heroesSpellbook[heroName].Contains(spellName))
                            {
                                Console.WriteLine($"{heroName} has already learnt {spellName}.");
                            }
                            else
                            {
                                heroesSpellbook[heroName].Add(spellName);
                            }
                        }

                        break;

                    case "Unlearn":
                        
                        spellName = command[2];

                        if (!heroesSpellbook.ContainsKey(heroName))
                        {
                            Console.WriteLine($"{heroName} doesn't exist.");
                        }
                        else
                        {
                            if (!heroesSpellbook[heroName].Contains(spellName))
                            {
                                Console.WriteLine($"{heroName} doesn't know {spellName}.");
                            }
                            else
                            {
                                heroesSpellbook[heroName].Remove(spellName);
                            }
                        }

                        break;
                }

            }

            Console.WriteLine("Heroes:");

            foreach (var hero in heroesSpellbook.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"== {hero.Key}: {string.Join(", ", hero.Value)}");
            }

        }
    }
}
