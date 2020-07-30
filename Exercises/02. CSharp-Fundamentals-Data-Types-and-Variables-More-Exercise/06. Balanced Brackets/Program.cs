using System;

namespace _06._Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {

            byte numberOfLines = byte.Parse(Console.ReadLine());

            bool isBalanced = false;
            bool isOpeningBracket = false;
            bool isClosingBracket = false;
            bool isNotPossible = false;


            for (byte i = 0; i < numberOfLines; i++)
            {
                string input = Console.ReadLine();

                if (input == "(")
                {
                    if (!isOpeningBracket)
                    {
                        isOpeningBracket = true;
                        isBalanced = false;
                    }
                    else
                    {
                        isNotPossible = true;
                    }
                }
                else if (input == ")")
                {
                    if (isOpeningBracket && !isClosingBracket)
                    {
                        isClosingBracket = true;
                        isOpeningBracket = false;
                        isBalanced = true;
                    }
                    else
                    {
                        isNotPossible = true;
                    }
                }

                if (isBalanced)
                {
                    isOpeningBracket = false;
                    isClosingBracket = false;
                }
            }

            if (isBalanced && !isNotPossible)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
