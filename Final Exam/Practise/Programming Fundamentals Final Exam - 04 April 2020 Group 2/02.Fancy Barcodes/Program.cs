using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {

            string pattern = @"@#+(?<code>[A-Z][A-Za-z0-9]{4,}[A-Z])@#+";

            int barcodesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < barcodesCount; i++)
            {
                string input = Console.ReadLine();

                if (Regex.IsMatch(input, pattern))
                {
                    string barcode = Regex.Match(input, pattern).Groups["code"].ToString();

                    StringBuilder sb = new StringBuilder();

                    for (int j = 0; j < barcode.Length; j++)
                    {
                        
                        if (char.IsDigit(barcode[j]))
                        {
                            sb.Append(barcode[j]);
                        }
                    }

                    string productGroup = sb.ToString();

                    if (productGroup == "")
                    {
                        productGroup = "00";
                    }

                    Console.WriteLine($"Product group: {productGroup}");

                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }

            }

        }
    }
}
