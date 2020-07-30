using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> listOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = String.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                List<string> command = input.Split().ToList();

                switch (command[0])
                {
                    case "Delete":

                        int elementToDelete = int.Parse(command[1]);

                        for (int i = 0; i < listOfNumbers.Count; i++)
                        {
                            listOfNumbers.Remove(elementToDelete);
                        }

                        break;

                    case "Insert":

                        int elementToInsert = int.Parse(command[1]);
                        int position = int.Parse(command[2]);

                        listOfNumbers.Insert(position, elementToInsert);

                        break;
                }
            }

            Console.WriteLine(string.Join(" ", listOfNumbers));

        }
    }
}
