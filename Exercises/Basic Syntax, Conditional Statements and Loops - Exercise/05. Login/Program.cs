using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string password = string.Empty;
                        
            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }


            int failCounter = 0;
            string input = string.Empty;

            while ((input = Console.ReadLine()) != password)
            {
                failCounter++;

                if (failCounter == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }

                Console.WriteLine("Incorrect password. Try again.");
            }

            if (input == password)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}
