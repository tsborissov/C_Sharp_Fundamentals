using System;
using System.Linq;

namespace _01._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {

            string activationKey = Console.ReadLine();


            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Generate") { break; }

                string[] command = input.Split(">>>").ToArray();

                switch (command[0])
                {
                    case "Contains":

                        string substring = command[1];

                        if (activationKey.Contains(substring))
                        {
                            Console.WriteLine($"{activationKey} contains {substring}");
                        }
                        else
                        {
                            Console.WriteLine("Substring not found!");
                        }

                        break;

                    case "Flip":

                        int startIndexToFlip = int.Parse(command[2]);
                        int endIndexToFlip = int.Parse(command[3]);
                        int lengthToFlip = endIndexToFlip - startIndexToFlip;

                        if (command[1] == "Upper")
                        {
                            activationKey = activationKey.Substring(0, startIndexToFlip)
                                + activationKey.Substring(startIndexToFlip, lengthToFlip).ToUpper()
                                + activationKey.Substring(endIndexToFlip, activationKey.Length - endIndexToFlip);
                        }
                        else
                        {
                            activationKey = activationKey.Substring(0, startIndexToFlip)
                                + activationKey.Substring(startIndexToFlip, lengthToFlip).ToLower()
                                + activationKey.Substring(endIndexToFlip, activationKey.Length - endIndexToFlip);
                        }

                        Console.WriteLine(activationKey);

                        break;

                    case "Slice":

                        int startIndexToSlice = int.Parse(command[1]);
                        int endIndexToSlice = int.Parse(command[2]);
                        int lengthToSlice = endIndexToSlice - startIndexToSlice;

                        activationKey = activationKey.Remove(startIndexToSlice, lengthToSlice);

                        Console.WriteLine(activationKey);

                        break;
                }
            }

            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}
