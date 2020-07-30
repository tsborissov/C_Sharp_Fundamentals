using System;
using System.Collections.Generic;

namespace _04._List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> productNames = new List<string>();

            for (int i = 0; i < n; i++)
            {
                productNames.Add(Console.ReadLine());
            }

            productNames.Sort();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i + 1}.{productNames[i]}");
            }
        }
    }
}
