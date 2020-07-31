using System;
using System.Linq;
using System.Text;

namespace _1._Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {

            string password = Console.ReadLine();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Done")
                { 
                    break;
                }

                string[] command = input.Split().ToArray();

                switch (command[0])
                {
                    case "TakeOdd":

                        StringBuilder oddChars = new StringBuilder();

                        for (int i = 1; i < password.Length; i += 2)
                        {
                            oddChars.Append(password[i]);
                        }

                        password = oddChars.ToString();

                        Console.WriteLine(password);

                        break;

                    case "Cut":

                        int index = int.Parse(command[1]);
                        int lenght = int.Parse(command[2]);

                        password = password.Remove(index, lenght);

                        Console.WriteLine(password);

                        break;

                    case "Substitute":

                        string substring = command[1];
                        string substitute = command[2];

                        if (password.Contains(substring))
                        {
                            password = password.Replace(substring, substitute);

                            Console.WriteLine(password);
                        }
                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                        }

                        break;


                }
            }

            Console.WriteLine($"Your password is: {password}");

        }
    }
}
