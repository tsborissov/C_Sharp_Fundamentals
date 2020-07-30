using System;

namespace _01._Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOfStrings = int.Parse(Console.ReadLine());

            int[] codes = new int[numberOfStrings];

            for (int i = 0; i < numberOfStrings; i++)
            {
                string inputString = Console.ReadLine();

                int stringCode = 0;

                for (int j = 0; j < inputString.Length; j++)
                {
                    bool isVowel = 
                        inputString[j] == 'a' ||
                        inputString[j] == 'e' ||
                        inputString[j] == 'i' ||
                        inputString[j] == 'o' ||
                        inputString[j] == 'u';


                    if (isVowel)
                    {
                        stringCode += inputString[j] * inputString.Length;
                    }
                    else
                    {
                        stringCode += inputString[j] / inputString.Length;
                    }

                }

                codes[i] = stringCode;

            }

            Array.Sort(codes);

            for (int k = 0; k < codes.Length; k++)
            {
                if(codes[k] != 0)
                {
                    Console.WriteLine(codes[k]);
                }
            }
        }
    }
}
