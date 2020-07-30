using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Tanks_Collector
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> ownedTanks = Console.ReadLine().Split(", ").ToList();

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfCommands; i++)
            {
                string[] commandWithParameters = Console.ReadLine().Split(", ").ToArray();

                string command = commandWithParameters[0];

                string tankName;
                int index = -1;

                switch (command)
                {
                    case "Add":

                        tankName = commandWithParameters[1];

                        if (ownedTanks.Exists(x => x == tankName))
                        {
                            Console.WriteLine("Tank is already bought");
                        }
                        else
                        {
                            ownedTanks.Add(tankName);
                            Console.WriteLine("Tank successfully bought");
                        }


                        break;

                        case "Remove":

                        tankName = commandWithParameters[1];

                        if (ownedTanks.Exists(x => x == tankName))
                        {
                            Console.WriteLine("Tank successfully sold");
                            ownedTanks.Remove(tankName);
                        }
                        else
                        {
                            Console.WriteLine("Tank not found");
                        }

                        break;

                        case "Remove At":

                        index = int.Parse(commandWithParameters[1]);

                        if (index > -1 && index < ownedTanks.Count)
                        {
                            ownedTanks.RemoveAt(index);
                            Console.WriteLine("Tank successfully sold");
                        }
                        else
                        {
                            Console.WriteLine("Index out of range");
                        }

                        break;

                        case "Insert":

                        index = int.Parse(commandWithParameters[1]);
                        tankName = commandWithParameters[2];

                        if (index > -1 && index < ownedTanks.Count)
                        {
                            if(ownedTanks.Exists(x => x == tankName))
                            {
                                Console.WriteLine("Tank is already bought");
                            }
                            else
                            {
                                ownedTanks.Insert(index, tankName);
                                
                                Console.WriteLine("Tank successfully bought");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Index out of range");
                        }

                        break;

                }
            }

            Console.WriteLine(string.Join(", ", ownedTanks));

        }
    }
}
