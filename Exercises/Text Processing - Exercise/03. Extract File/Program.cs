using System;
using System.Linq;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int index = input.LastIndexOf('\\') + 1;
            int length = input.Length - index;

            string fileAndType = input.Substring(index, length);

            string filename = fileAndType.Split('.')[0];
            string extension = fileAndType.Split('.')[1];

            Console.WriteLine($"File name: {filename}");
            Console.WriteLine($"File extension: {extension}");
        }
    }

}
