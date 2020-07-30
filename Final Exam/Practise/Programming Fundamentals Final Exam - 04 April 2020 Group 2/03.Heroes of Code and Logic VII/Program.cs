using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Heroes_of_Code_and_Logic_VII
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOfHeroes = int.Parse(Console.ReadLine());

            Dictionary<string, Hero> heroesCollection = new Dictionary<string, Hero>();

            for (int i = 0; i < numberOfHeroes; i++)
            {
                string[] heroInput = Console.ReadLine().Split().ToArray();

                string name = heroInput[0];
                int hitPoints = int.Parse(heroInput[1]);
                int manaPoints = int.Parse(heroInput[2]);

                heroesCollection.Add(name, new Hero(name, hitPoints, manaPoints));
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End") { break; }

                string[] command = input.Split(" - ").ToArray();

                string heroName = command[1];

                switch (command[0])
                {
                    case "CastSpell":

                        int manaPointsNeeded = int.Parse(command[2]);
                        string spellName = command[3];

                        if (heroesCollection[heroName].ManaPoints >= manaPointsNeeded)
                        {
                            heroesCollection[heroName].ManaPoints -= manaPointsNeeded;

                            Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroesCollection[heroName].ManaPoints} MP!");
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                        }

                        break;


                    case "TakeDamage":

                        int damage = int.Parse(command[2]);
                        string attacker = command[3];

                        heroesCollection[heroName].HitPoints -= damage;

                        if (heroesCollection[heroName].HitPoints > 0)
                        {
                            Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroesCollection[heroName].HitPoints} HP left!");
                        }
                        else
                        {
                            heroesCollection.Remove(heroName);

                            Console.WriteLine($"{heroName} has been killed by {attacker}!");
                        }

                        break;


                    case "Recharge":

                        int rechargeMP = int.Parse(command[2]);

                        heroesCollection[heroName].ManaPoints += rechargeMP;

                        if (heroesCollection[heroName].ManaPoints > 200)
                        {
                            rechargeMP -= heroesCollection[heroName].ManaPoints - 200;

                            heroesCollection[heroName].ManaPoints = 200;
                        }

                        Console.WriteLine($"{heroName} recharged for {rechargeMP} MP!");

                        break;


                    case "Heal":

                        int recoverHP = int.Parse(command[2]);

                        heroesCollection[heroName].HitPoints += recoverHP;

                        if (heroesCollection[heroName].HitPoints > 100)
                        {
                            recoverHP -= heroesCollection[heroName].HitPoints - 100;

                            heroesCollection[heroName].HitPoints = 100;
                        }

                        Console.WriteLine($"{heroName} healed for {recoverHP} HP!");

                        break;
                }
            }

            foreach (var hero in heroesCollection.OrderByDescending(x => x.Value.HitPoints).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{hero.Key}");
                Console.WriteLine($"  HP: {hero.Value.HitPoints}");
                Console.WriteLine($"  MP: {hero.Value.ManaPoints}");
            }

        }
    }

    public class Hero
    {
        public string HeroName { get; set; }
        public int HitPoints { get; set; }
        public int ManaPoints { get; set; }

        public Hero(string name, int hitPoints, int manaPoints)
        {
            this.HeroName = name;
            this.HitPoints = hitPoints;
            this.ManaPoints = manaPoints;
        }
    }
}
