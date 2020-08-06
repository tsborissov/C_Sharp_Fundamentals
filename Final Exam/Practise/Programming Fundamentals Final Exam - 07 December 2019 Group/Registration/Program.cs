using System;
using System.Text.RegularExpressions;

namespace Registration
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int successfulRegistrations = 0;

            string pattern = @"U\$(?<username>[A-Z][a-z]{2,})U\$P@\$(?<password>[A-Za-z]{5,}[0-9]+)P@\$";

            for (int i = 0; i < n; i++)
            {
                string registrationInput = Console.ReadLine();

                if (Regex.IsMatch(registrationInput, pattern))
                {
                    successfulRegistrations++;

                    Console.WriteLine("Registration was successful");

                    string username = Regex.Match(registrationInput, pattern).Groups["username"].ToString();
                    string password = Regex.Match(registrationInput, pattern).Groups["password"].ToString();

                    Console.WriteLine($"Username: {username}, Password: {password}");
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                }
            }

            Console.WriteLine($"Successful registrations: {successfulRegistrations}");

        }
    }
}
