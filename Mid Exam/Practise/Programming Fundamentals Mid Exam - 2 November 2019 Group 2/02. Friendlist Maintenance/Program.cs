using System;
using System.Linq;

namespace _02._Friendlist_Maintenance
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] userNames = Console.ReadLine().Split(", ").ToArray();

            int blacklistedNamesCount = 0;
            int lostNamesCount = 0;

            string input = string.Empty;
            while((input = Console.ReadLine()) != "Report")
            {
                string[] commandWithParameters = input.Split().ToArray();

                string command = commandWithParameters[0];

                switch (command)
                {
                    case "Blacklist":

                        string nameToBlacklist = commandWithParameters[1];

                        bool isNameFound = false;

                        for (int i = 0; i < userNames.Length; i++)
                        {
                            if (userNames[i] == nameToBlacklist)
                            {
                                isNameFound = true;

                                blacklistedNamesCount++;

                                Console.WriteLine($"{nameToBlacklist} was blacklisted.");
                                userNames[i] = "Blacklisted";
                                break;
                            }
                        }

                        if (!isNameFound)
                        {
                            Console.WriteLine($"{nameToBlacklist} was not found.");
                        }

                        break;

                    case "Error":

                        int indexToCheck = int.Parse(commandWithParameters[1]);

                        if (userNames[indexToCheck] != "Blacklisted" && userNames[indexToCheck] != "Lost")
                        {
                            lostNamesCount++;
                            
                            Console.WriteLine($"{userNames[indexToCheck]} was lost due to an error.");

                            userNames[indexToCheck] = "Lost";
                        }

                        break;

                    case "Change":

                        int indexToChange = int.Parse(commandWithParameters[1]);
                        string newName = commandWithParameters[2];

                        if (indexToChange > -1 && indexToChange < userNames.Length)
                        {
                            Console.WriteLine($"{userNames[indexToChange]} changed his username to {newName}.");
                            userNames[indexToChange] = newName;
                        }

                        break;
                }
            }

            Console.WriteLine($"Blacklisted names: {blacklistedNamesCount}");
            Console.WriteLine($"Lost names: {lostNamesCount}");
            Console.WriteLine(string.Join(' ', userNames));

        }
    }
}
