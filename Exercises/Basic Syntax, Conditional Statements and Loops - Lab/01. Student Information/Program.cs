using System;

namespace _01._Student_Information
{
    class Program
    {
        static void Main(string[] args)
        {

            string studentName = Console.ReadLine();
            int studentAge = int.Parse(Console.ReadLine());
            double studentGrade = double.Parse(Console.ReadLine());

            Console.WriteLine("Name: {0}, Age: {1}, Grade: {2:F2}", studentName, studentAge, studentGrade);

        }
    }
}
