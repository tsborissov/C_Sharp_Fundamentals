using System;
using System.Text.RegularExpressions;

namespace The_Isle_of_Man_TT_Race
{
    class Program
    {
        static void Main(string[] args)
        {

            string pattern = @"^(#|\$|%|\*|&)(?<name>[A-Z][A-Za-z]+)(\1)=(?<length>[0-9]+)!!(?<code>[\S]+)$";

            bool isCoordinatesFound = false;

            while (!isCoordinatesFound)
            {
                string input = Console.ReadLine();
                
                if (Regex.IsMatch(input, pattern))
                {
                    string name = Regex.Match(input, pattern).Groups["name"].ToString();
                    int length = int.Parse(Regex.Match(input, pattern).Groups["length"].ToString());
                    char[] code = Regex.Match(input, pattern).Groups["code"].ToString().ToCharArray();

                    if (length == code.Length)
                    {
                        for (int i = 0; i < code.Length; i++)
                        {
                            code[i] += (char)length;
                        }

                        isCoordinatesFound = true;

                        string decryptedCode = string.Join("", code);

                        Console.WriteLine($"Coordinates found! {name} -> {decryptedCode}");

                    }
                    else
                    {
                        Console.WriteLine("Nothing found!");
                    }
                }
                else
                {
                    Console.WriteLine("Nothing found!");
                }
            }
        }
    }
}
