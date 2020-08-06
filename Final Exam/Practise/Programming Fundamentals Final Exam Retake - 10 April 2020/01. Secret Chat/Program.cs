using System;
using System.Linq;

namespace _01._Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {

            string message = Console.ReadLine();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Reveal") { break; }

                string[] command = input.Split(":|:").ToArray();

                switch (command[0])
                {
                    case "InsertSpace":

                        int indexToInsert = int.Parse(command[1]);

                        message = message.Insert(indexToInsert, " ");

                        break;

                    case "Reverse":

                        string substr = command[1];

                        if (message.Contains(substr))
                        {
                            string substrReversed = new string(substr.Reverse().ToArray());

                            message = message.Remove(message.IndexOf(substr), substr.Length);

                            message = string.Concat(message, substrReversed);

                        }
                        else
                        {
                            Console.WriteLine("error");
                            continue;
                        }

                        break;

                    case "ChangeAll":

                        string substrToReplace = command[1];
                        string replacement = command[2];

                        message = message.Replace(substrToReplace, replacement);

                        break;
                }

                Console.WriteLine(message);

            }

            Console.WriteLine($"You have a new text message: {message}");

        }
    }
}
