using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> registeredUsers = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split().ToArray();

                switch (command[0])
                {
                    case "register":

                        string usernameToRegister = command[1];
                        string licensePlateNumber = command[2];

                        if (!registeredUsers.ContainsKey(usernameToRegister))
                        {
                            registeredUsers.Add(usernameToRegister, licensePlateNumber);

                            Console.WriteLine($"{usernameToRegister} registered {licensePlateNumber} successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                        }

                        break;

                    case "unregister":

                        string usernameToUnregister = command[1];

                        if (registeredUsers.ContainsKey(usernameToUnregister))
                        {
                            registeredUsers.Remove(usernameToUnregister);

                            Console.WriteLine($"{usernameToUnregister} unregistered successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: user {usernameToUnregister} not found");
                        }

                        break;
                }
            }

            foreach (var pair in registeredUsers)
            {
                Console.WriteLine($"{pair.Key} => {pair.Value}");
            }

        }
    }
}
