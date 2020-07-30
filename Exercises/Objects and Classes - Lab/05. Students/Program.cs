using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;

            List<Student> studentsList = new List<Student>();

            while((command = Console.ReadLine()) != "end")
            {
                string[] studentData = command.Split().ToArray();

                string firstName = studentData[0];
                string lastName = studentData[1];
                int age = int.Parse(studentData[2]);
                string hometown = studentData[3];

                studentsList.Add(new Student(firstName, lastName, age, hometown));
            }

            string filterInput = Console.ReadLine();

            List<Student> filteredStudentsByTown = studentsList.Where(x => x.Hometown == filterInput).ToList();

            Console.WriteLine(string.Join(Environment.NewLine, filteredStudentsByTown));

        }
    }

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Hometown { get; set; }

        public Student(string firstName, string lastName, int age, string hometown)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Hometown = hometown;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} is {Age} years old.";
        }


    }
}
