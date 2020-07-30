using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Inventory
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> items = Console.ReadLine()
                .Split(", ")
                .ToList();

            string input = string.Empty;
            while((input = Console.ReadLine()) != "Craft!")
            {
                string[] commandRaw = input.Split(" - ").ToArray();

                string command = commandRaw[0];
                string item = commandRaw[1];

                switch (command)
                {
                    case "Collect":

                        if (!(items.Exists(x => x == item)))
                        {
                            items.Add(item);
                        }

                        break;

                    case "Drop":

                        items.Remove(item);

                        break;

                    case "Combine Items":

                        string[] oldNewItems = item.Split(':').ToArray();
                        string oldItem = oldNewItems[0];
                        string newItem = oldNewItems[1];

                        int oldItemIndex = items.IndexOf(oldItem);

                        if (oldItemIndex != -1)
                        {
                            items.Insert(oldItemIndex + 1, newItem);
                        }

                        break;

                    case "Renew":

                        int itemIndex = items.IndexOf(item);

                        if (itemIndex != -1)
                        {
                            items.Add(items[itemIndex]);
                            items.RemoveAt(itemIndex);
                        }

                        break;
                }
            }

            Console.WriteLine(string.Join(", ", items));

        }
    }
}
