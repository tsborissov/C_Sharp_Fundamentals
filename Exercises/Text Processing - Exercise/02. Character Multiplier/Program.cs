using System;
using System.Linq;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            Console.WriteLine(CharacterMultiplier(input[0], input[1]));

        }

        static int CharacterMultiplier(string x, string y)
        {
            int result = 0;

            if(x.Length == y.Length)
            {
                for (int i = 0; i < x.Length; i++)
                {
                    result += x[i] * y[i];
                }
            }
            else
            {
                if(x.Length > y.Length)
                {
                    for (int j = 0; j < y.Length; j++)
                    {
                        result += x[j] * y[j];
                    }

                    for (int k = y.Length; k < x.Length; k++)
                    {
                        result += x[k];
                    }
                }
                else
                {
                    for (int j = 0; j < x.Length; j++)
                    {
                        result += x[j] * y[j];
                    }

                    for (int k = x.Length; k < y.Length; k++)
                    {
                        result += y[k];
                    }
                }
            }


            return result;
        }
    }
}
