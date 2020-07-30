using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = String.Empty;

            while((input = Console.ReadLine()) != "end")
            {
                List<string> command = input.Split().ToList();

                switch (command[0])
                {
                    case "Add": numbers.Add(int.Parse(command[1])); break;
                    case "Remove": numbers.Remove(int.Parse(command[1])); break;
                    case "RemoveAt": numbers.RemoveAt(int.Parse(command[1])); break;
                    case "Insert": numbers.Insert(int.Parse(command[2]), int.Parse(command[1])); break;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
