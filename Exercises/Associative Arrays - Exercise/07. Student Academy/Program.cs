using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<double>> studentGrades = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentGrades.ContainsKey(name))
                {
                    studentGrades.Add(name, new List<double>() { grade });
                }
                else
                {
                    studentGrades[name].Add(grade);
                }
            }

            Dictionary<string, double> averageGrades = new Dictionary<string, double>();

            foreach (var pair in studentGrades)
            {
                averageGrades.Add(pair.Key, pair.Value.Average());
            }

            averageGrades = averageGrades.Where(x => x.Value >= 4.50).OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            foreach (var pair in averageGrades)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value:F2}");
            }
        }
    }
}
