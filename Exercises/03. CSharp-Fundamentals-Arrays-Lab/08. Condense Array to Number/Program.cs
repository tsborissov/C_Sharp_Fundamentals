using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            while (arr.Length > 1)
            {
                int[] condesedArr = new int[arr.Length - 1];

                for (int i = 0; i < condesedArr.Length; i++)
                {
                    condesedArr[i] = arr[i] + arr[i + 1];
                }

                arr = condesedArr;
            }

            Console.WriteLine(arr[0]);

        }
    }
}
