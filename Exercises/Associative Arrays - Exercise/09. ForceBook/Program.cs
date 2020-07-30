using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> forceBook = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Lumpawaroo") { break; }

                string[] command = input.Split().ToArray();

                switch (command[1])
                {
                    case "|":

                        break;

                    case "->":

                        break;
                }

            }


        }
    }
}
