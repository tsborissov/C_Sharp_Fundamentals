using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, City> cities = new Dictionary<string, City>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Sail")
                {
                    break;
                }

                string[] cityInput = input.Split("||").ToArray();

                string name = cityInput[0];
                int population = int.Parse(cityInput[1]);
                int gold = int.Parse(cityInput[2]);

                if (!cities.ContainsKey(name))
                {
                    cities.Add(name, new City(name, population, gold));
                }
                else
                {
                    cities[name].Population += population;
                    cities[name].Gold += gold;
                }
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                string[] eventsInput = input.Split("=>").ToArray();

                string town = eventsInput[1];
                int gold = 0;

                switch (eventsInput[0])
                {
                    case "Plunder":

                        int people = int.Parse(eventsInput[2]);
                        gold = int.Parse(eventsInput[3]);

                        cities[town].Population -= people;
                        cities[town].Gold -= gold;

                        Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");

                        if (cities[town].Population <= 0 || cities[town].Gold <= 0)
                        {
                            cities.Remove(town);
                            Console.WriteLine($"{town} has been wiped off the map!");
                        }

                        break;

                    case "Prosper":

                        gold = int.Parse(eventsInput[2]);

                        if (gold < 0)
                        {
                            Console.WriteLine("Gold added cannot be a negative number!");
                            break;
                        }

                        cities[town].Gold += gold;

                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {cities[town].Gold} gold.");

                        break;
                }
            }

            if (cities.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");

                foreach (var city in cities.OrderByDescending(x => x.Value.Gold).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{city.Key} -> Population: {city.Value.Population} citizens, Gold: {city.Value.Gold} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }

            

        }
    }

    class City
    {
        public string CityName { get; set; }
        public int Population { get; set; }
        public int Gold { get; set; }

        public City(string cityName, int population, int gold)
        {
            this.CityName = cityName;
            this.Population = population;
            this.Gold = gold;
        }
    }
}
