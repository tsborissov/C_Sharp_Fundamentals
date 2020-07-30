﻿using System;

namespace _04._Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {

            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 30;

            if (minutes > 59)
            {
                minutes -= 60;
                hours += 1;
            }

            if (hours > 23)
            {
                hours -= 24;
            }

            Console.WriteLine("{0}:{1:D2}", hours, minutes);
        }
    }
}
