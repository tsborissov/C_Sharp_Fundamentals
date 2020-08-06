using System;
using System.Linq;

namespace String_Manipulator___Group_1
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputString = Console.ReadLine();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                    string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                switch (command[0])
                {
                    case "Translate":

                        string charToReplace = command[1];
                        string replacement = command[2];

                        inputString = inputString.Replace(charToReplace, replacement);

                        Console.WriteLine(inputString);

                        break;

                    case "Includes":

                        string textToCheck = command[1];

                        Console.WriteLine(inputString.Contains(textToCheck));

                        break;

                    case "Start":

                        string startString = command[1];

                        Console.WriteLine(inputString.StartsWith(startString));

                        break;

                    case "Lowercase":

                        inputString = inputString.ToLower();

                        Console.WriteLine(inputString);

                        break;

                    case "FindIndex":

                        string endString = command[1];

                        int lastIndex = inputString.LastIndexOf(endString);

                        Console.WriteLine(lastIndex);

                        break;

                    case "Remove":

                        int startIndex = int.Parse(command[1]);
                        int countToRemove = int.Parse(command[2]);

                        inputString = inputString.Remove(startIndex, countToRemove);

                        Console.WriteLine(inputString);

                        break;
                }
            }
        }
    }
}
