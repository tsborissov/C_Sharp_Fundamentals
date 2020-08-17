using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Ad_Astra
{
    class Program
    {
        static void Main(string[] args)
        {

            string pattern = @"([#\|])(?<item>[A-Za-z]+\s*[A-Za-z]*)\1(?<date>[0-9]{2}\/[0-9]{2}\/[0-9]{2})\1(?<calories>[0-9]{1,5})\1";

            string input = Console.ReadLine();

            MatchCollection foodCollection = Regex.Matches(input, pattern);

            int caloriesTotal = 0;

            foreach (Match item in foodCollection)
            {
                int calories = int.Parse(item.Groups["calories"].Value.ToString());

                caloriesTotal += calories;
            }

            int days = caloriesTotal / 2000;

            Console.WriteLine($"You have food to last you for: {days} days!");

            foreach (Match food in foodCollection)
            {
                Console.WriteLine($"Item: {food.Groups["item"].Value}, Best before: {food.Groups["date"].Value}, Nutrition: {food.Groups["calories"].Value}");
            }
        }
    }
}
