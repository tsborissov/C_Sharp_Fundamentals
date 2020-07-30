using System;
using System.Linq;

namespace _02._Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arrayToBeModified = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string input = string.Empty;
            while((input = Console.ReadLine()) != "end")
            {
                string[] commandRaw = input.Split().ToArray();

                string command = commandRaw[0];

                switch (command)
                {

                    case "swap":

                        int swapIndex1 = int.Parse(commandRaw[1]);
                        int swapIndex2 = int.Parse(commandRaw[2]);

                        int tempStorage = arrayToBeModified[swapIndex1];
                        arrayToBeModified[swapIndex1] = arrayToBeModified[swapIndex2];
                        arrayToBeModified[swapIndex2] = tempStorage;

                        break;

                    case "multiply":

                        int multiplyIndex1 = int.Parse(commandRaw[1]);
                        int multiplyIndex2 = int.Parse(commandRaw[2]);

                        int product = arrayToBeModified[multiplyIndex1] * arrayToBeModified[multiplyIndex2];

                        arrayToBeModified[multiplyIndex1] = product;

                        break;

                    case "decrease":

                        for (int i = 0; i < arrayToBeModified.Length; i++)
                        {
                            arrayToBeModified[i] -= 1;
                        }

                        break;
                }
            }

            Console.WriteLine(string.Join(", ", arrayToBeModified));

        }
    }
}
