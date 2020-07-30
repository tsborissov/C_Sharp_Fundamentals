using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = String.Empty;

            bool isListChanged = false;

            while ((input = Console.ReadLine()) != "end")
            {
                List<string> command = input.Split().ToList();

                switch (command[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(command[1]));
                        isListChanged = true;
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(command[1]));
                        isListChanged = true;
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(command[1]));
                        isListChanged = true;
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        isListChanged = true;
                        break;


                    case "Contains":
                        if (numbers.Contains(int.Parse(command[1])))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        Console.WriteLine(PrintEven(numbers));
                        break;
                    case "PrintOdd":
                        Console.WriteLine(PrintOdd(numbers));
                        break;
                    case "GetSum":
                        Console.WriteLine(GetSum(numbers));
                        break;
                    case "Filter":
                        Console.WriteLine(FilterList(numbers, command[1], command[2]));
                        break;
                }
            }

            if(isListChanged)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }

        static string PrintEven(List<int> num)
        {
            List<int> evenNumbers = new List<int>();

            for (int i = 0; i < num.Count; i++)
            {
                if(num[i] % 2 == 0)
                {
                    evenNumbers.Add(num[i]);
                }
            }

            return string.Join(" ", evenNumbers);
        }

        static string PrintOdd(List<int> num)
        {
            List<int> evenNumbers = new List<int>();

            for (int i = 0; i < num.Count; i++)
            {
                if (num[i] % 2 != 0)
                {
                    evenNumbers.Add(num[i]);
                }
            }

            return string.Join(" ", evenNumbers);
        }

        static int GetSum(List<int> num)
        {
            return num.Sum();
        }

        static string FilterList(List<int> num, string condition, string number)
        {
            List<int> result = new List<int>();

            switch (condition)
            {
                case "<":
                    for (int i = 0; i < num.Count; i++)
                    {
                        if (num[i] < int.Parse(number))
                        {
                            result.Add(num[i]);
                        }
                    }
                    break;
                case ">":
                    for (int i = 0; i < num.Count; i++)
                    {
                        if (num[i] > int.Parse(number))
                        {
                            result.Add(num[i]);
                        }
                    }
                    break;
                case ">=":
                    for (int i = 0; i < num.Count; i++)
                    {
                        if (num[i] >= int.Parse(number))
                        {
                            result.Add(num[i]);
                        }
                    }
                    break;
                case "<=":
                    for (int i = 0; i < num.Count; i++)
                    {
                        if (num[i] <= int.Parse(number))
                        {
                            result.Add(num[i]);
                        }
                    }
                    break;
            }

            return string.Join(" ", result);
        }
    }
}
