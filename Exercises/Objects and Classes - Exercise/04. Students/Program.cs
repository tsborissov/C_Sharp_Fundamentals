using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < countOfStudents; i++)
            {
                var studentInfo = Console.ReadLine()
                    .Split()
                    .ToArray();

                students.Add(new Student(studentInfo[0], studentInfo[1], double.Parse(studentInfo[2])));

            }

            students = students.OrderByDescending(x => x.Grade).ToList();

            Console.WriteLine(string.Join(Environment.NewLine, students));

        }
    }

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public Student(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:F2}";
        }

    }
}
