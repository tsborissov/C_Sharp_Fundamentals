using System;
using System.Linq;

namespace Username
{
    class Program
    {
        static void Main(string[] args)
        {

            string username = Console.ReadLine();

            while (true)
            {
                string commandInput = Console.ReadLine();
                if (commandInput == "Sign up")
                {
                    break;
                }

                string[] command = commandInput.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                switch (command[0])
                {
                    case "Case":

                        if(command[1] == "lower")
                        {
                            username = username.ToLower();

                            Console.WriteLine(username);
                        }
                        else if (command[1] == "upper")
                        {
                            username = username.ToUpper();

                            Console.WriteLine(username);
                        }

                        break;

                    case "Reverse":

                        int startIndex = int.Parse(command[1]);
                        int endIndex = int.Parse(command[2]);

                        bool isValidIndex = startIndex >= 0 && startIndex < username.Length && endIndex >= 0 && endIndex <= username.Length && endIndex > startIndex;

                        if (isValidIndex)
                        {
                            int length = endIndex - startIndex + 1;
                            string reversed = string.Join("", username.Substring(startIndex, length).ToCharArray().Reverse().ToArray());

                            Console.WriteLine(reversed);
                        }

                        break;

                    case "Cut":

                        string substr = command[1];

                        if (username.Contains(substr))
                        {
                            username = username.Replace(substr, "");

                            Console.WriteLine(username);
                        }
                        else
                        {
                            Console.WriteLine($"The word {username} doesn't contain {substr}.");
                        }

                        break;

                    case "Replace":

                        string charToReplace = command[1];

                        username = username.Replace(charToReplace, "*");

                        Console.WriteLine(username);

                        break;

                    case "Check":

                        string charToCheck = command[1];

                        if (username.Contains(charToCheck))
                        {
                            Console.WriteLine("Valid");
                        }
                        else
                        {
                            Console.WriteLine($"Your username must contain {charToCheck}.");
                        }

                        break;
                }
            }
        }
    }
}
