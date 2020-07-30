using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = string.Empty;

            List<Person> persons = new List<Person>();

            while((input = Console.ReadLine()) != "End")
            {
                string[] peopleDetails = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                persons.Add(new Person(peopleDetails[0], peopleDetails[1], int.Parse(peopleDetails[2])));
            }

            Console.WriteLine(string.Join(Environment.NewLine, persons.OrderBy(x => x.Age)));

        }

    }

    public class Person
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }

        public Person(string name, string id, int age)
        {
            this.Name = name;
            this.Id = id;
            this.Age = age;
        }

        public override string ToString()
        {
            return $"{Name} with ID: {Id} is {Age} years old.";
        }

    }
}
