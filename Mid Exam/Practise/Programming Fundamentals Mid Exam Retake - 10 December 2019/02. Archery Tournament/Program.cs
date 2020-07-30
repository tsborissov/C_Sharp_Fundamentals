using System;
using System.Linq;

namespace _02._Archery_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] targets = Console.ReadLine()
                .Split("|")
                .Select(int.Parse)
                .ToArray();

            int points = 0;

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Game over")
            {
                string[] commandWithParameters = input.Split('@').ToArray();

                string command = commandWithParameters[0];

                int index = -1;
                int length = 0;
                int targetIndex = -1;

                switch (command)
                {
                    case "Shoot Left":

                        index = int.Parse(commandWithParameters[1]);
                        length = int.Parse(commandWithParameters[2]);

                        if (index > -1 && index < targets.Length)
                        {
                            if (length > targets.Length)
                            {
                                length /= targets.Length;
                            }
                            
                            targetIndex = index - length;

                            if (targetIndex < 0)
                            {
                                targetIndex = targets.Length + index - length;
                            }

                            if (targets[targetIndex] >= 5)
                            {
                                points += 5;
                                targets[targetIndex] -= 5;
                            }
                            else
                            {
                                points += targets[targetIndex];
                                targets[targetIndex] = 0;
                            }
                        }
                        break;

                    case "Shoot Right":

                        index = int.Parse(commandWithParameters[1]);
                        length = int.Parse(commandWithParameters[2]);

                        int lastIndex = targets.Length - 1;

                        if (index > -1 && index <= lastIndex)
                        {
                            if (length > targets.Length)
                            {
                                length %= targets.Length;
                            }

                            targetIndex = index + length;

                            if (targetIndex > lastIndex)
                            {
                                targetIndex -= targets.Length;
                            }


                            if (targets[targetIndex] >= 5)
                            {
                                points += 5;
                                targets[targetIndex] -= 5;
                            }
                            else
                            {
                                points += targets[targetIndex];
                                targets[targetIndex] = 0;
                            }
                        }
                        break;

                    case "Reverse":

                        targets = targets.Reverse().ToArray();

                        break;
                }
            }

            Console.WriteLine(string.Join(" - ", targets));
            Console.WriteLine($"Iskren finished the archery tournament with {points} points!");
        }
    }
}
