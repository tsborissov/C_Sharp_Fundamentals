using System;

namespace _02._Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());

            Console.WriteLine(FindClosestToCenter(a, b, c, d));

        }

        static string FindClosestToCenter(double x1, double y1, double x2, double y2)
        {
            double firstDistanceToZero = CalculateDistanceToCenterPoint(x1, y1);
            double secondDistanceToZero = CalculateDistanceToCenterPoint(x2, y2);

            bool isFirstCloser = firstDistanceToZero <= secondDistanceToZero;

            if (isFirstCloser)
            {
                return "(" + x1.ToString() + ", " + y1.ToString() + ")"; 
                    //+ " -> First distance: " + firstDistanceToZero.ToString("0.0000") 
                    //+ " Second distance: " + secondDistanceToZero.ToString("0.0000");
            }
            else
            {
                return "(" + x2.ToString() + ", " + y2.ToString() + ")"; 
                    //+ " -> First distance: " + firstDistanceToZero.ToString("0.0000") 
                    //+ " Second distance: " + secondDistanceToZero.ToString("0.0000");
            }
        }

        static double CalculateDistanceToCenterPoint(double x, double y)
        {
            double distanceToCenter = 0;

            if (x != 0 && y != 0)
            {
                distanceToCenter = Math.Sqrt(x * x + y * y);
            }
            else if (x != 0 && y == 0)
            {
                distanceToCenter = Math.Abs(x);
            }
            else if (x == 0 && y != 0)
            {
                distanceToCenter = Math.Abs(y);
            }

            return distanceToCenter;
        }
    }
}
