using System;

namespace _02._Grades
{
    class Program
    {
        static void Main(string[] args)
        {

            double input = double.Parse(Console.ReadLine());

            GradeInWords(input);

        }


        static void GradeInWords(double GradeInDigits)
        {
            if (GradeInDigits >= 2.00 && GradeInDigits <= 2.99)
            {
                Console.WriteLine("Fail");
            }
            else if (GradeInDigits >= 3.00 && GradeInDigits <= 3.49)
            {
                Console.WriteLine("Poor");
            }
            else if (GradeInDigits >= 3.50 && GradeInDigits <= 4.49)
            {
                Console.WriteLine("Good");
            }
            else if (GradeInDigits >= 4.50 && GradeInDigits <= 5.49)
            {
                Console.WriteLine("Very good");
            }
            else if (GradeInDigits >= 5.50 && GradeInDigits <= 6.00)
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
