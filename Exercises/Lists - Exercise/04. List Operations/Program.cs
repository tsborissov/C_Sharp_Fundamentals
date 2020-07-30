using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input = String.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                List<string> operations = input.Split().ToList();

                switch (operations[0])
                {
                    case "Add":

                        int numberToAdd = int.Parse(operations[1]);
                        numbers.Add(numberToAdd);

                        break;

                    case "Insert":

                        int numberToInsert = int.Parse(operations[1]);
                        int indexToInsertAt = int.Parse(operations[2]);

                        if (indexToInsertAt >= 0 && indexToInsertAt < numbers.Count)
                        {
                            numbers.Insert(indexToInsertAt, numberToInsert);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }

                        break;

                    case "Remove":

                        int indexToRemove = int.Parse(operations[1]);

                        if (indexToRemove >= 0 && indexToRemove < numbers.Count)
                        {
                            numbers.RemoveAt(indexToRemove);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }

                        break;

                    case "Shift":

                        string direction = operations[1];
                        int shiftCounts = int.Parse(operations[2]);
                       
                        switch (direction)
                        {
                            case "left":

                                for (int i = 0; i < shiftCounts; i++)
                                {
                                    numbers.Add(numbers[0]);
                                    numbers.RemoveAt(0);
                                }

                                break;

                            case "right":

                                for (int i = 0; i < shiftCounts; i++)
                                {
                                    numbers.Insert(0, numbers[numbers.Count - 1]);
                                    numbers.RemoveAt(numbers.Count - 1);
                                }

                                break;
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
