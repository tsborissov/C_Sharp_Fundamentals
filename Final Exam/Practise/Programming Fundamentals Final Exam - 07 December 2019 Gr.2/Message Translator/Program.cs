using System;
using System.Text.RegularExpressions;

namespace Message_Translator
{
    class Program
    {
        static void Main(string[] args)
        {

            string pattern = @"!(?<command>[A-Z][a-z]{2,})!:\[(?<message>[A-Za-z]{8,})\]";

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string messageInput = Console.ReadLine();

                if (!Regex.IsMatch(messageInput, pattern))
                {
                    Console.WriteLine("The message is invalid");
                }
                else
                {
                    string message = Regex.Match(messageInput, pattern).Groups["message"].ToString();

                    int[] messageArray = new int[message.Length];

                    for (int j = 0; j < message.Length; j++)
                    {
                        messageArray[j] = message[j];
                    }

                    string encryptedMessage = string.Join(' ', messageArray);

                    string command = Regex.Match(messageInput, pattern).Groups["command"].ToString();

                    Console.WriteLine($"{command}: {encryptedMessage}");
                }
            }
        }
    }
}
