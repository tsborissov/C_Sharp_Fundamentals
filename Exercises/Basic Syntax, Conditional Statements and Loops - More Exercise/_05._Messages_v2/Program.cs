using System;

namespace _05._Messages_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            int smsLenght = int.Parse(Console.ReadLine());

            string smsContent = String.Empty;

            string two = "abc";
            string three = "def";
            string four = "ghi";
            string five = "jkl";
            string six = "mno";
            string seven = "pqrs";
            string eight = "tuv";
            string nine = "wxyz";

            for (int i = 1; i <= smsLenght; i++)
            {
                string input = Console.ReadLine();

                int leadingDigit = int.Parse(input[0].ToString());

                switch (leadingDigit)
                {
                    case 2: smsContent += two[input.Length - 1]; break;
                    case 3: smsContent += three[input.Length - 1]; break;
                    case 4: smsContent += four[input.Length - 1]; break;
                    case 5: smsContent += five[input.Length - 1]; break;
                    case 6: smsContent += six[input.Length - 1]; break;
                    case 7: smsContent += seven[input.Length - 1]; break;
                    case 8: smsContent += eight[input.Length - 1]; break;
                    case 9: smsContent += nine[input.Length - 1]; break;
                    case 0: smsContent += " "; break;
                }

            }

            Console.WriteLine(smsContent);

        }
    }
}
