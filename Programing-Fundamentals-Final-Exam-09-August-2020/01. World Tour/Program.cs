using System;

namespace _01._World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {

            string allStops = Console.ReadLine();

            while (true)
            {
                string inputCommand = Console.ReadLine();
                if (inputCommand == "Travel")
                {
                    break;
                }

                string[] command = inputCommand.Split(':', StringSplitOptions.RemoveEmptyEntries);

                switch (command[0])
                {
                    case "Add Stop":

                        int indexToInsertAt = int.Parse(command[1]);
                        string stringToInsert = command[2];

                        if (indexToInsertAt >= 0 && indexToInsertAt < allStops.Length)
                        {
                            allStops = allStops.Insert(indexToInsertAt, stringToInsert);
                        }

                        Console.WriteLine(allStops);

                        break;

                    case "Remove Stop":

                        int startIndex = int.Parse(command[1]);
                        int endIndex = int.Parse(command[2]);

                        bool isValidIndex = startIndex > -1 && startIndex < allStops.Length && endIndex >= startIndex && endIndex < allStops.Length;

                        if (isValidIndex)
                        {
                            int countToRemove = endIndex - startIndex + 1;

                            allStops = allStops.Remove(startIndex, countToRemove);
                        }

                        Console.WriteLine(allStops);

                        break;

                    case "Switch":

                        string oldString = command[1];
                        string newString = command[2];

                        allStops = allStops.Replace(oldString, newString);

                        Console.WriteLine(allStops);

                        break;
                }
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {allStops}");

        }
    }
}
