using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {

            string number = String.Empty;

            while ((number = Console.ReadLine()) != "END")
            {
                PalindromeNumberCheck(number);
            }

        }

        static void PalindromeNumberCheck(string str)
        {
            string reverseStr = String.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                reverseStr += str[str.Length - i - 1];
            }

            if (str == reverseStr)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
