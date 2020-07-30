using System;
using System.Linq;

namespace _02._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n  = int.Parse(Console.ReadLine());

            int startingNumber = 1;

            int[] tempArr = {startingNumber};

            for (int row = 1; row <= n; row++)
            {
                int[] array = new int[row];

                for (int column = 0; column < row; column++)
                {
                    if (column == 0)
                    {
                        array[column] = tempArr[0];
                    }
                    else if (column == array.Length - 1)
                    {
                        array[column] = tempArr[0];
                    }
                    else
                    {
                        array[column] = tempArr[column - 1] + tempArr[column];
                    }

                }

                Console.WriteLine(string.Join(" ", array));

                tempArr = array;
            }
        }
    }
}
