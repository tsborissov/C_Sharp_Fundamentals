using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {

            double widhtInput = double.Parse(Console.ReadLine());
            double heightInput = double.Parse(Console.ReadLine());

            double area = GetRectangleArea(widhtInput, heightInput);

            Console.WriteLine(area);

        }

        static double GetRectangleArea(double width, double height)
        {
            return width * height;
        }
    }
}
