using System;
using System.Linq;

namespace _02._MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] dungeonsRooms = Console.ReadLine()
                .Split('|')
                .ToArray();

            int health = 100;
            int bitcoins = 0;
            bool isDead = false;

            for (int i = 0; i < dungeonsRooms.Length; i++)
            {
                string[] commandWithParameters = dungeonsRooms[i].Split().ToArray();

                string command = commandWithParameters[0];
                int commandParameter = int.Parse(commandWithParameters[1]);

                switch (command)
                {
                    case "potion":

                        int healed = commandParameter;

                        if (health + healed > 100)
                        {
                            healed = 100 - health;
                            health = 100;
                        }
                        else
                        {
                            health += healed;
                        }

                        Console.WriteLine($"You healed for {healed} hp.");
                        Console.WriteLine($"Current health: {health} hp.");

                        break;

                    case "chest":

                        bitcoins += commandParameter;

                        Console.WriteLine($"You found {commandParameter} bitcoins.");

                        break;

                    default:

                        health -= commandParameter;

                        if (health > 0)
                        {
                            Console.WriteLine($"You slayed {command}.");
                        }
                        else
                        {
                            isDead = true;
                            Console.WriteLine($"You died! Killed by {command}.");
                            Console.WriteLine($"Best room: {i + 1}");
                        }

                        break;
                }

                if (isDead)
                {
                    break;
                }

            }

            if (!isDead)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");

            }
        }
    }
}
