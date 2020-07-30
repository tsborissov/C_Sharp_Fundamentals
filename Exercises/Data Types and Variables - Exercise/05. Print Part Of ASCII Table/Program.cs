using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {

            int startIndex = int.Parse(Console.ReadLine());
            int endIndex = int.Parse(Console.ReadLine());

            for (char i = (char)startIndex; i <= (char)endIndex; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
