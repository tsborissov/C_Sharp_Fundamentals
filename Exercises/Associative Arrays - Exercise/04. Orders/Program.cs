using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var ProductsInventory = new Dictionary<string, Product>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "buy")
                {
                    break;
                }

                string[] splittedInput = input.Split().ToArray();

                string productName = splittedInput[0];
                double productPrice = double.Parse(splittedInput[1]);
                int productQuantity = int.Parse(splittedInput[2]);

                Product newProduct = new Product(productName, productPrice, productQuantity);

                if(ProductsInventory.ContainsKey(productName))
                {
                    ProductsInventory[productName].Quantity += productQuantity;

                    if(ProductsInventory[productName].Price != productPrice)
                    {
                        ProductsInventory[productName].Price = productPrice;
                    }

                }
                else
                {
                    ProductsInventory.Add(productName, newProduct);
                }
            }

            foreach (var item in ProductsInventory)
            {
                Console.WriteLine($"{item.Key} -> {item.Value.TotalPrice:F2}");
            }

        }
    }

    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice
        {
            get { return Price * Quantity; }
        }

        public Product(string name, double price, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }
    }
}
