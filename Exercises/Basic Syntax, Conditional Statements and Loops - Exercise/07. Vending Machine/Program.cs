using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {

            //0.1, 0.2, 0.5, 1, and 2 coins

            double ammountTotal = 0;
            string inputMoney = String.Empty;

            while ((inputMoney = Console.ReadLine()) != "Start")
            {
                double coin = double.Parse(inputMoney);
                bool isValidCoin = coin == 0.1 || coin == 0.2 || coin == 0.5 || coin == 1 || coin == 2;

                if (isValidCoin)
                {
                    ammountTotal += coin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }
            }

            //"Nuts", "Water", "Crisps", "Soda", "Coke". The prices are: 2.0, 0.7, 1.5, 0.8, 1.0

            string inputProduct = String.Empty;

            while ((inputProduct = Console.ReadLine()) != "End")
            {
                bool isValidProduct = inputProduct == "Nuts" || inputProduct == "Water" || inputProduct == "Crisps" || inputProduct == "Soda" || inputProduct == "Coke";
                double productPrice = 0;

                if (!isValidProduct)
                {
                    Console.WriteLine("Invalid product");
                    continue;
                }

                switch (inputProduct)
                {
                    case "Nuts": productPrice = 2.0; break;
                    case "Water": productPrice = 0.7; break;
                    case "Crisps": productPrice = 1.5; break;
                    case "Soda": productPrice = 0.8; break;
                    case "Coke": productPrice = 1.0; break;
                }

                if (productPrice > ammountTotal)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                else
                {
                    ammountTotal -= productPrice;
                    Console.WriteLine($"Purchased {inputProduct.ToLower()}");
                }

            }

            Console.WriteLine($"Change: {ammountTotal:F2}");

        }
    }
}
