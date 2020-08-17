using System;
using System.Text.RegularExpressions;

namespace _06.Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string emailPattern = @"(?<=\s)(?<username>[a-zA-Z0-9]+[.\-_a-zA-Z0-9]*(?<=[a-zA-Z0-9]))@(?<hostname>[a-zA-Z0-9]+[.\-_a-zA-Z0-9]*(?<=[a-zA-Z0-9])\.[a-z]{2,})";

            string inputText = Console.ReadLine();

            MatchCollection emails = Regex.Matches(inputText, emailPattern);

            foreach (Match email in emails)
            {
                string username = email.Groups["username"].ToString();
                string hostname = email.Groups["hostname"].ToString();
                
                Console.WriteLine($"{username}@{hostname}");
            }
        }
    }
}
