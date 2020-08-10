using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {

            string pattern = @">>(?<product>[A-Za-z]+)<<(?<price>[0-9]+\.*[0-9]*)!(?<quantity>[0-9]+)";

            List<string> products = new List<string>();
            double totalPrice = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Purchase") { break; }

                if (Regex.IsMatch(input, pattern))
                {
                    string product = Regex.Match(input, pattern).Groups["product"].ToString();
                    double price = double.Parse(Regex.Match(input, pattern).Groups["price"].ToString());
                    int quantity = int.Parse(Regex.Match(input, pattern).Groups["quantity"].ToString());

                    products.Add(product);

                    totalPrice += price * quantity;
                }
            }

            Console.WriteLine("Bought furniture:");

            if (products.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, products));
            }

            Console.WriteLine($"Total money spend: {totalPrice:F2}");
        }
    }
}
