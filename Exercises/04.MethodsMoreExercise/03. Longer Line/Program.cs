using System;

namespace _03._Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] coordinatesInput = new double[8];

            for (int i = 0; i < coordinatesInput.Length; i++)
            {
                coordinatesInput[i] = double.Parse(Console.ReadLine());
            }

            CompareLines(coordinatesInput);

        }

        static void CompareLines(double[] coordinatesArr)
        {
            double[] longestLineCoordinates = new double[4];
            double longestLineLength = 0;

            int numberOfLines = coordinatesArr.Length / 4;

            for (int i = 0; i < numberOfLines; i++)
            {
                double[] currentLineCoordinates = { coordinatesArr[i * 4], coordinatesArr[i * 4 + 1], coordinatesArr[i * 4 + 2], coordinatesArr[i * 4 + 3] };

                double currentLength = CalculateLineLength(currentLineCoordinates);

                if (currentLength > longestLineLength)
                {
                    longestLineLength = currentLength;
                    longestLineCoordinates = currentLineCoordinates;
                }
            }

            FindClosestToCenterAndPrint(longestLineCoordinates);

        }

        static double CalculateLineLength(double[] lineCoordinates)
        {
            return Math.Sqrt(Math.Pow((lineCoordinates[0] - lineCoordinates[2]), 2) + Math.Pow((lineCoordinates[1] - lineCoordinates[3]), 2));
        }

        static void FindClosestToCenterAndPrint(double[] coordinates)
        {
            double x1 = coordinates[0];
            double y1 = coordinates[1];
            double x2 = coordinates[2];
            double y2 = coordinates[3];

            double firstDistanceToZero = CalculateDistanceToCenterPoint(x1, y1);
            double secondDistanceToZero = CalculateDistanceToCenterPoint(x2, y2);

            bool isFirstCloser = firstDistanceToZero <= secondDistanceToZero;

            if (isFirstCloser)
            {
                Console.WriteLine($"({x1.ToString()}, {y1.ToString()})({x2.ToString()}, {y2.ToString()})");
            }
            else
            {
                Console.WriteLine($"({x2.ToString()}, {y2.ToString()})({x1.ToString()}, {y1.ToString()})");
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
