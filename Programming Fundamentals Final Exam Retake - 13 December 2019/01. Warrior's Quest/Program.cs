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

                        int indexToDispel = int.Parse(command[1]);

                        if (!(indexToDispel > -1 && indexToDispel < skill.Length))
                        {
                            Console.WriteLine("Dispel too weak.");
                            break;
                        }

                        char letterToDispel = command[2].ToCharArray()[0];

                        char[] skillArr = skill.ToCharArray();

                        skillArr[indexToDispel] = letterToDispel;

                        skill = new string(skillArr);

                        Console.WriteLine("Success!");

                        break;

                    case "Target":

                        if (command[1] == "Change")
                        {
                            string firstSubstring = command[2];
                            string secondSubstring = command[3];

                            skill = skill.Replace(firstSubstring, secondSubstring);

                            Console.WriteLine(skill);
                        }
                        else if (command [1] == "Remove")
                        {
                            string substring = command[2];

                            skill = skill.Replace(substring, "");

                            Console.WriteLine(skill);
                        }

                        break;

                    default:
                        Console.WriteLine("Command doesn't exist!");
                            break;
                }
            }
        }
    }
}
