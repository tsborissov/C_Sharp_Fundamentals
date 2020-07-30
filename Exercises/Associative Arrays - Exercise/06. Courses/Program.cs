using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<string>> registeredCourses = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end") { break; }

                string courseName = input.Split(" : ")[0];
                string studentName = input.Split(" : ")[1];

                if (!registeredCourses.ContainsKey(courseName))
                {
                    registeredCourses.Add(courseName, new List<string> { studentName });
                }
                else
                {
                    registeredCourses[courseName].Add(studentName);
                }

            }

            foreach (var pair in registeredCourses.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{pair.Key}: {pair.Value.Count}");

                foreach (var item in pair.Value.OrderBy(name => name))
                {
                    Console.WriteLine($"-- {item}");
                }
            }

        }
    }
}
