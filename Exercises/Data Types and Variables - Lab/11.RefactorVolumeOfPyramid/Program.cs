﻿using System;

namespace _11.RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            double lenght = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());

            double pyramidVolume = (lenght * width * height) / 3;

            Console.Write($"Pyramid Volume: {pyramidVolume:f2}");
        }
    }
}
