using System;
using System.Linq;

namespace _01._Warrior_s_Quest
{
    class Program
    {
        static void Main(string[] args)
        {

            string skill = Console.ReadLine();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "For Azeroth")
                {
                    break;
                }

                string[] command = input.Split().ToArray();

                switch (command[0])
                {
                    case "GladiatorStance":

                        skill = skill.ToUpper();

                        Console.WriteLine(skill);

                        break;

                    case "DefensiveStance":

                        skill = skill.ToLower();

                        Console.WriteLine(skill);

                        break;

                    case "Dispel":




                        break;

                    case "Target":

                        if (command[1] == "Change")
                        {

                        }
                        else if (command [1] == "Remove")
                        {

                        }


                        break;
                }
            }

        }
    }
}
