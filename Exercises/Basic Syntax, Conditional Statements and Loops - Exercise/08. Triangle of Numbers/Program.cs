﻿using System;

namespace _08._Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                for (int column = 1; column <= row; column++)
                {
                    Console.Write($"{row} ");
                }

                Console.WriteLine();

            }    

        }
    }
}
