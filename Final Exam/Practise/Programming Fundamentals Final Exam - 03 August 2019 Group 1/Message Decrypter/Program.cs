using System;
using System.Text.RegularExpressions;

namespace Message_Decrypter
{
    class Program
    {
        static void Main(string[] args)
        {

            string pattern = @"^([$%])(?<tag>[A-Z][a-z]{2,})\1:\s\[(?<firstNumber>[0-9]+)\]\|\[(?<secondNumber>[0-9]+)\]\|\[(?<thirdNumber>[0-9]+)\]\|$";

            int numberOfInputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfInputs; i++)
            {
                string message = Console.ReadLine();

                if(!Regex.IsMatch(message,pattern))
                {
                    Console.WriteLine("Valid message not found!");
                }
                else
                {
                    int firstNumber = int.Parse(Regex.Match(message, pattern).Groups["firstNumber"].ToString());
                    int secondNumber = int.Parse(Regex.Match(message, pattern).Groups["secondNumber"].ToString());
                    int thirdNumber = int.Parse(Regex.Match(message, pattern).Groups["thirdNumber"].ToString());

                    string messageTag = Regex.Match(message, pattern).Groups["tag"].ToString();

                    string decryptedMessage = string.Concat((char)firstNumber, (char)secondNumber, (char)thirdNumber);

                    Console.WriteLine($"{messageTag}: {decryptedMessage}");
                }
            }

        }
    }
}
