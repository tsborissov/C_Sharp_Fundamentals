using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {

            string productInput = Console.ReadLine();
            double QuantityInput = double.Parse(Console.ReadLine());

            TotalPriceCalculateAndPrint(productInput, QuantityInput);

        }

        static void TotalPriceCalculateAndPrint(string product, double quantity)
        {
            switch (product)
            {
                case "coffee": Console.WriteLine($"{(quantity * 1.50):F2}"); break;
                case "water": Console.WriteLine($"{(quantity * 1.00):F2}"); break;
                case "coke": Console.WriteLine($"{(quantity * 1.40):F2}"); break;
                case "snacks": Console.WriteLine($"{(quantity * 2.00):F2}"); break;
            }
        }
    }
}
