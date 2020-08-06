using System;
using System.Collections.Generic;
using System.Linq;

namespace Inbox_Manager
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<string>> sentEmails = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Statistics")
                {
                    break;
                }

                string[] command = input.Split("->", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string username = command[1];

                switch (command[0])
                {
                    case "Add":

                        if (!sentEmails.ContainsKey(username))
                        {
                            sentEmails.Add(username, new List<string>());
                        }
                        else
                        {
                            Console.WriteLine($"{username} is already registered");
                        }

                        break;

                    case "Send":

                        string email = command[2];

                        if (sentEmails.ContainsKey(username))
                        {
                            sentEmails[username].Add(email);
                        }

                        break;

                    case "Delete":

                        if (sentEmails.ContainsKey(username))
                        {
                            sentEmails.Remove(username);
                        }
                        else
                        {
                            Console.WriteLine($"{username} not found!");
                        }

                        break;
                }
            }

            Console.WriteLine($"Users count: {sentEmails.Count}");

            foreach (var user in sentEmails.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine(user.Key);

                foreach (var email in user.Value)
                {
                    Console.WriteLine($" - {email}");
                }
            }
        }
    }
}
