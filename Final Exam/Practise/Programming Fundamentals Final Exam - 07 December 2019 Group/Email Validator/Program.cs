using System;
using System.Linq;

namespace Email_Validator
{
    class Program
    {
        static void Main(string[] args)
        {

            string email = Console.ReadLine();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Complete")
                {
                    break;
                }

                string[] command = input.Split().ToArray();

                switch (command[0])
                {
                    case "Make":

                        if (command[1] == "Upper")
                        {
                            email = email.ToUpper();

                            Console.WriteLine(email);
                        }
                        else if (command[1] == "Lower")
                        {
                            email = email.ToLower();

                            Console.WriteLine(email);
                        }

                        break;

                    case "GetDomain":

                        int count = int.Parse(command[1]);
                        int startIndex = email.Length - count;

                        Console.WriteLine(email.Substring(startIndex, count));

                        break;

                    case "GetUsername":

                        int endIndex = email.IndexOf('@');

                        if (endIndex > -1)
                        {
                            Console.WriteLine(email.Substring(0, endIndex));
                        }
                        else
                        {
                            Console.WriteLine($"The email {email} doesn't contain the @ symbol.");
                        }

                        break;

                    case "Replace":

                        char charToReplace = char.Parse(command[1]);

                        email = email.Replace(charToReplace, '-');

                        Console.WriteLine(email);

                        break;

                    case "Encrypt":

                        int[] encryptedEmail = new int[email.Length];

                        for (int i = 0; i < email.Length; i++)
                        {
                            encryptedEmail[i] = email[i];
                        }

                        Console.WriteLine(string.Join(' ', encryptedEmail));

                        break;
                }
            }

        }
    }
}
