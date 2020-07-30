using System;
using System.Collections.Generic;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {

            SortedDictionary<string, List<string>> companies = new SortedDictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End") { break; }

                string companyName = input.Split(" -> ")[0];
                string id = input.Split(" -> ")[1];

                if (!companies.ContainsKey(companyName))
                {
                    companies.Add(companyName, new List<string> { id });
                }
                else
                {
                    if (!companies[companyName].Contains(id))
                    {
                        companies[companyName].Add(id);
                    }
                }
            }

            foreach (var pair in companies)
            {
                Console.WriteLine(pair.Key);

                foreach (var item in pair.Value)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}
