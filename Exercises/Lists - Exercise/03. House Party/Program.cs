using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOfCommands = int.Parse(Console.ReadLine());

            List<string> guests = new List<string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                List<string> command = Console.ReadLine().Split().ToList();

                string guestName = command[0];
                string action = command[2];

                switch (action)
                {
                    case "going!":

                        if (guests.Contains(guestName))
                        {
                            Console.WriteLine($"{guestName} is already in the list!");
                        }
                        else
                        {
                            guests.Add(guestName);
                        }

                        break;

                    case "not":

                        if (guests.Contains(guestName))
                        {
                            guests.Remove(guestName);
                        }
                        else
                        {
                            Console.WriteLine($"{guestName} is not in the list!");
                        }

                        break;
                }
            }

            foreach (var guest in guests)
            {
                Console.WriteLine(guest);
            }

        }
    }
}
