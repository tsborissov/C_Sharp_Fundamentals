using System;
using System.Linq;

namespace String_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputString = Console.ReadLine();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Done")
                {
                    break;
                }

                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                switch (command[0])
                {

                    case "Change":

                        string charToReplace = command[1];
                        string replacement = command[2];

                        inputString = inputString.Replace(charToReplace, replacement);

                        Console.WriteLine(inputString);

                        break;

                    case "Includes":

                        string containString = command[1];

                        Console.WriteLine(inputString.Contains(containString));

                        break;

                    case "End":

                        string endString = command[1];

                        Console.WriteLine(inputString.EndsWith(endString));

                        break;

                    case "Uppercase":

                        inputString = inputString.ToUpper();

                        Console.WriteLine(inputString);

                        break;

                    case "FindIndex":

                        string charToFind = command[1];

                        int firstIndex = inputString.IndexOf(charToFind);

                        Console.WriteLine(firstIndex);

                        break;

                    case "Cut":

                        int startIndex = int.Parse(command[1]);
                        int lenght = int.Parse(command[2]);

                        inputString = inputString.Substring(startIndex, lenght);

                        Console.WriteLine(inputString);

                        break;

                }
            }
        }
    }
}
