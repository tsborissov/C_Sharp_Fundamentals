using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {

            string pattern = @"%(?<customer>[A-Z][a-z]+)%[^\|\$\%\.]*<(?<product>[A-Za-z]+)>[^\|\$\%\.]*\|(?<count>\d+)\|[^\|\$\%\.]*?(?<price>\d+\.?\d*?)(?=\$)";

            double totalIncome = 0;

            
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of shift") { break; }

                if (Regex.IsMatch(input, pattern))
                {
                    string customer = Regex.Match(input, pattern).Groups["customer"].ToString();
                    string product = Regex.Match(input, pattern).Groups["product"].ToString();
                    double price = double.Parse(Regex.Match(input, pattern).Groups["price"].ToString());
                    double count = double.Parse(Regex.Match(input, pattern).Groups["count"].ToString());

                    double totalPrice = price * count;

                    totalIncome += totalPrice;

                    Console.WriteLine($"{customer}: {product} - {totalPrice:F2}");
                }
            }

            Console.WriteLine($"Total income: {totalIncome:F2}");

        }
    }
}
