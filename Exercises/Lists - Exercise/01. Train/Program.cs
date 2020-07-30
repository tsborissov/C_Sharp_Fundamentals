using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberOfPassengersPerWagon = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxWagonCapacity = int.Parse(Console.ReadLine());

            string input = string.Empty;

            while((input = Console.ReadLine()) != "end")
            {
                List<string> command = input.Split().ToList();

                if (command[0] == "Add")
                {
                    numberOfPassengersPerWagon.Add(int.Parse(command[1]));
                }
                else
                {
                    int newPassengers = int.Parse(command[0]);

                    for (int i = 0; i < numberOfPassengersPerWagon.Count; i++)
                    {
                        if (numberOfPassengersPerWagon[i] + newPassengers <= maxWagonCapacity)
                        {
                            numberOfPassengersPerWagon[i] += newPassengers;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numberOfPassengersPerWagon));

        }
    }
}
