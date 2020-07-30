using System;
using System.Linq;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            Console.WriteLine(CountOfVowels(input));

        }


        
        static int CountOfVowels(string inputString)
        {
            int vowelsCounter = 0;

            char[] vowels = new char[] { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U' };

            
            for (int i = 0; i < inputString.Length; i++)
            {
                if (vowels.Contains(inputString[i]))
                {
                    vowelsCounter++;
                }
                
            }

            return vowelsCounter;

        }


    }
}
