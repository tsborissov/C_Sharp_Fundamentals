using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] usernames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            List<string> validUsernames = new List<string>();

            for (int i = 0; i < usernames.Length; i++)
            {

                if (usernames[i].Length >= 3 && usernames[i].Length <= 16)
                {

                    string currentUsername = usernames[i];

                    bool isValid = true;

                    for (int j = 0; j < currentUsername.Length; j++)
                    {
                        if (!(char.IsLetterOrDigit(currentUsername[j]) || currentUsername[j] == '-' || currentUsername[j] == '_'))
                        {
                            isValid = false;
                            break;
                        }
                    }

                    if(isValid)
                    {
                        validUsernames.Add(currentUsername);
                    }

                }

            }

            Console.WriteLine(string.Join(Environment.NewLine, validUsernames));

        }
    }
}
