using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.Santa_s_Secret_Helper
{
    class Program
    {
        static void Main(string[] args)
        {

            int key = int.Parse(Console.ReadLine());

            string pattern = @"^[^@]*@(?<name>[A-Za-z]+)[^@\-\!:>]*!(?<behaviour>[GN])!";

            List<string> goodChildren = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }

                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < input.Length; i++)
                {
                    sb.Append((char)(input[i] - key));
                }

                string message = sb.ToString();

                if (Regex.IsMatch(message, pattern))
                {
                    string name = Regex.Match(message, pattern).Groups["name"].ToString();
                    string behaviour = Regex.Match(message, pattern).Groups["behaviour"].ToString();

                    if (behaviour == "G")
                    {
                        goodChildren.Add(name);
                    }
                }

            }

            Console.WriteLine(string.Join(Environment.NewLine, goodChildren));

        }
    }
}
