using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int[] firstArr = new int[n];
            int[] secondArr = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] tempArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                    firstArr[i] = tempArr[0];
                    secondArr[i] = tempArr[1];
                }
                else
                {
                    firstArr[i] = tempArr[1];
                    secondArr[i] = tempArr[0];
                }
                
            }

            Console.WriteLine(string.Join(' ', firstArr));
            Console.WriteLine(string.Join(' ', secondArr));

        }
    }
}
