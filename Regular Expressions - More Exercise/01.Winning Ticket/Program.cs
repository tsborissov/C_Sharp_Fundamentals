using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01.Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {

            //string winningPattern = @"^[^@#$^]{0,4}(?<left>[@#$^]{6,10})[^@#$^]*(?<right>\1)[^@#$^]{0,4}$";

            string winningPattern = @"[@#$^]{6,10}";

            char[] delimiters = new char[] { ',', ' ' };

            string[] tickets = Console.ReadLine().Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i].Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    string leftPart = tickets[i].Substring(0, 10);
                    string rightPart = tickets[i].Substring(10, 10);

                    string leftWinPart = Regex.Match(leftPart, winningPattern).ToString();
                    string rightWinPart = Regex.Match(rightPart, winningPattern).ToString();

                    if (leftWinPart == "" || rightWinPart == "")
                    {
                        Console.WriteLine($"ticket \"{tickets[i]}\" - no match");
                    }
                    else
                    {
                        if (leftWinPart[0] == rightWinPart[0] && leftWinPart.Length == rightWinPart.Length)
                        {
                            if (leftWinPart.Length == 10)
                            {
                                Console.WriteLine($"ticket \"{tickets[i]}\" - {leftWinPart.Length}{leftWinPart[0]} Jackpot!");
                            }
                            else
                            {
                                Console.WriteLine($"ticket \"{tickets[i]}\" - {leftWinPart.Length}{leftWinPart[0]}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{tickets[i]}\" - no match");
                        }
                    }
                }
            }
        }
    }
}
