using System;
using System.Linq;
using System.Text;

namespace _01._The_Imitation_Game
{
    class Program
    {
        static void Main(string[] args)
        {

            string message = Console.ReadLine();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Decode")
                {
                    break;
                }

                string[] command = input.Split('|').ToArray();

                switch (command[0])
                {
                    case "Move":

                        int lengthToMove = int.Parse(command[1]);

                        if (lengthToMove < message.Length)
                        {
                            string partToMove = message.Substring(0, lengthToMove);

                            StringBuilder sb = new StringBuilder(message);

                            sb.Remove(0, lengthToMove);
                            sb.Append(partToMove);

                            message = sb.ToString();
                        }

                        break;

                    case "Insert":

                        int indexToInsert = int.Parse(command[1]);
                        string valueToInsert = command[2];

                        if (indexToInsert <= message.Length)
                        {
                            message = message.Insert(indexToInsert, valueToInsert);
                        }

                        break;

                    case "ChangeAll":

                        string substringToReplace = command[1];
                        string replacement = command[2];

                        message = message.Replace(substringToReplace, replacement);

                        break;
                }

            }

            Console.WriteLine($"The decrypted message is: {message}");

        }
    }
}
