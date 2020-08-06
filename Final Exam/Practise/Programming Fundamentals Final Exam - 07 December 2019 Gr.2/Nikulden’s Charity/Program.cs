using System;
using System.Linq;

namespace Nikulden_s_Charity
{
    class Program
    {
        static void Main(string[] args)
        {

            string message = Console.ReadLine();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Finish")
                {
                    break;
                }

                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                int startIndex = 0;
                int endIndex = 0;
                bool isValidIndex = false;

                switch (command[0])
                {
                    
                    case "Replace":

                        char currentChar = char.Parse(command[1]);
                        char newChar = char.Parse(command[2]);

                        message = message.Replace(currentChar, newChar);

                        Console.WriteLine(message);

                        break;

                    case "Cut":

                        startIndex = int.Parse(command[1]);
                        endIndex = int.Parse(command[2]);

                        isValidIndex = (startIndex > -1 && startIndex < message.Length) && (endIndex > -1 && endIndex < message.Length);

                        if (isValidIndex)
                        {
                            message = message.Remove(startIndex, endIndex - startIndex + 1);

                            Console.WriteLine(message);
                        }
                        else
                        {
                            Console.WriteLine("Invalid indexes!");
                        }

                        break;

                    case "Make":

                        if (command[1] == "Upper")
                        {
                            message = message.ToUpper();
                        }
                        else if (command[1] == "Lower")
                        {
                            message = message.ToLower();
                        }

                        Console.WriteLine(message);

                        break;

                    case "Check":

                        if (message.Contains(command[1]))
                        {
                            Console.WriteLine($"Message contains {command[1]}");
                        }
                        else
                        {
                            Console.WriteLine($"Message doesn't contain {command[1]}");
                        }

                        break;

                    case "Sum":

                        startIndex = int.Parse(command[1]);
                        endIndex = int.Parse(command[2]);

                        isValidIndex = startIndex > -1 && startIndex < message.Length && endIndex > -1 && endIndex < message.Length;

                        if (isValidIndex)
                        {
                            string tempMessage = message.Substring(startIndex, endIndex - startIndex + 1);

                            int sum = 0;

                            for (int i = 0; i < tempMessage.Length; i++)
                            {
                                sum += tempMessage[i];
                            }

                            Console.WriteLine(sum);
                        }
                        else
                        {
                            Console.WriteLine("Invalid indexes!");
                        }

                        break;

                }
            }
        }
    }
}
