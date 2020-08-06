using System;
using System.Collections.Generic;
using System.Linq;

namespace Messages_Manager
{
    class Program
    {
        static void Main(string[] args)
        {

            int capacity = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> logBook = new Dictionary<string, Dictionary<string, int>>(); 

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Statistics")
                {
                    break;
                }

                string[] command = input.Split('=').ToArray();

                switch (command[0])
                {
                    
                    case "Add":

                        string userToAdd = command[1];
                        int sentMessages = int.Parse(command[2]);
                        int receivedMessages = int.Parse(command[3]);

                        if (!logBook.ContainsKey(userToAdd))
                        {
                            logBook.Add(userToAdd,
                                new Dictionary<string, int>()
                                {
                                     {"sent", sentMessages },
                                    {"received", receivedMessages }
                                });
                        }

                        break;

                    case "Message":

                        string sender = command[1];
                        string receiver = command[2];

                        if (logBook.ContainsKey(sender) && logBook.ContainsKey(receiver))
                        {
                            logBook[sender]["sent"]++;
                            logBook[receiver]["received"]++;

                            if (logBook[sender]["sent"] + logBook[sender]["received"] >= capacity)
                            {
                                logBook.Remove(sender);
                                Console.WriteLine($"{sender} reached the capacity!");
                            }

                            if (logBook[receiver]["received"] + logBook[receiver]["sent"] >= capacity)
                            {
                                logBook.Remove(receiver);
                                Console.WriteLine($"{receiver} reached the capacity!");
                            }
                        }

                        break;

                    case "Empty":

                        string userToRemove = command[1];

                        if (userToRemove == "All")
                        {
                            logBook.Clear();
                        }
                        else
                        {
                            if (logBook.ContainsKey(userToRemove))
                            {
                                logBook.Remove(userToRemove);
                            }
                        }

                        break;

                }
            }

            Console.WriteLine($"Users count: {logBook.Count}");

            foreach (var user in logBook.OrderByDescending(x => x.Value["received"]).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{user.Key} - {user.Value["sent"] + user.Value["received"]}");
            }

        }
    }
}
