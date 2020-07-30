using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> groceries = Console.ReadLine()
                .Split('!')
                .ToList();

            string input = string.Empty;
            while((input = Console.ReadLine()) != "Go Shopping!")
            {
                string[] command = input.Split().ToArray();

                switch (command[0])
                {
                    case "Urgent":
                        
                        if (!groceries.Exists(x => x == command[1]))
                        {
                            groceries.Insert(0, command[1]);
                        }

                        break;

                    case "Unnecessary":

                        if (groceries.Exists(x => x == command[1]))
                        {
                            groceries.Remove(command[1]);
                        }

                        break;

                    case "Correct":

                        if (groceries.Exists(x => x == command[1]))
                        {
                            int index = groceries.IndexOf(command[1]);

                            groceries.RemoveAt(index);
                            groceries.Insert(index, command[2]);
                        }

                        break;

                    case "Rearrange":

                        if (groceries.Exists(x => x == command[1]))
                        {
                            int index = groceries.IndexOf(command[1]);

                            groceries.RemoveAt(index);
                            groceries.Add(command[1]);
                        }

                        break;
                }

            }

            Console.WriteLine(string.Join(", ", groceries));
        }
    }
}
