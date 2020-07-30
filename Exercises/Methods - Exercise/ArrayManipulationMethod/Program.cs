using System;
using System.Linq;

namespace ArrayManipulationMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

            ArrayManipulation(arrayInput);

            Console.WriteLine(string.Join(", ", arrayInput));


        }

        static void ArrayManipulation(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= 2;
            }

            Console.WriteLine(string.Join(", ", array));
        }
    }
}
