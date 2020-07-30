using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> targets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input = string.Empty;
            while((input = Console.ReadLine()) != "End")
            {
                string[] commandWithParameters = input.Split();

                string command = commandWithParameters[0];
                int index = int.Parse(commandWithParameters[1]);
                int parameter = int.Parse(commandWithParameters[2]);

                switch (command)
                {
                    case "Shoot":

                        if (index >= 0 && index < targets.Count)
                        {
                            targets[index] -= parameter;
                            
                            if (targets[index] <= 0)
                            {
                                targets.RemoveAt(index);
                            }
                        }

                        break;

                    case "Add":

                        if (index >= 0 && index < targets.Count)
                        {
                            targets.Insert(index, parameter);
                        }
                        else
                        {
                            Console.WriteLine("Invalid placement!");
                        }

                        break;

                    case "Strike":

                        if (index >= 0 && index < targets.Count)
                        {
                            int startIndex = index - parameter;
                            int endIndex = index + parameter;

                            if (startIndex >=0 && endIndex < targets.Count)
                            {
                                int countToRemove = endIndex - startIndex + 1;
                                targets.RemoveRange(startIndex, countToRemove);
                            }
                            else
                            {
                                Console.WriteLine("Strike missed!");
                            }
                        }

                        break;
                }
            }

            Console.WriteLine(string.Join('|', targets));
        }
    }
}
