﻿using System;

namespace _01._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            double n3 = double.Parse(Console.ReadLine());

            if (n1 >= n2 && n1 >= n3)
            {
                Console.WriteLine(n1);
                
                if (n2 >= n3)
                {
                    Console.WriteLine(n2);
                    Console.WriteLine(n3);
                }
                else
                {
                    Console.WriteLine(n3);
                    Console.WriteLine(n2);
                }
            }
            else if (n2 >= n1 && n2 >= n3)
            {
                Console.WriteLine(n2);

                if (n1 >= n3)
                {
                    Console.WriteLine(n1);
                    Console.WriteLine(n3);
                }
                else
                {
                    Console.WriteLine(n3);
                    Console.WriteLine(n1);
                }
            }
            else if(n3 >= n1 && n3 >= n2)
            {
                Console.WriteLine(n3);

                if (n1 >= n2)
                {
                    Console.WriteLine(n1);
                    Console.WriteLine(n2);
                }
                else
                {
                    Console.WriteLine(n2);
                    Console.WriteLine(n1);
                }
            }
        }
    }
}
