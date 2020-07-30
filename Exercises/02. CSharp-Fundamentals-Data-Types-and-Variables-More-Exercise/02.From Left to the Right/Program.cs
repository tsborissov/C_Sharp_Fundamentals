using System;
//using System.Numerics;

namespace _02.From_Left_to_the_Right
{
    class Program
    {
        static void Main(string[] args)
        {

            byte linesOfInput = byte.Parse(Console.ReadLine());

            for (byte i = 0; i < linesOfInput; i++)
            {
                string userInput = Console.ReadLine();

                ushort spacePosition = 0;
                string leftNumberAsString = String.Empty;

                for (ushort j = 0; j < userInput.Length; j++)
                {
                    if (userInput[j] != ' ')
                    {
                        spacePosition++;
                        leftNumberAsString += userInput[j];
                    }
                    else
                    {
                        break;
                    }
                }

                string rightNumberAsString = String.Empty;

                for (ushort k = (ushort)(spacePosition + 1); k < userInput.Length; k++)
                {
                    rightNumberAsString += userInput[k];
                }


                long leftNumber = long.Parse(leftNumberAsString);
                long rightNumber = long.Parse(rightNumberAsString);


                if (leftNumber > rightNumber)
                {
                    leftNumber = Math.Abs(leftNumber);

                    long leftSum = 0;

                    while (leftNumber > 0)
                    {
                        leftSum += leftNumber % 10;
                        leftNumber /= 10;
                    }

                    Console.WriteLine(leftSum);
                }
                else
                {
                    rightNumber = Math.Abs(rightNumber);

                    long rightSum = 0;

                    while (rightNumber > 0)
                    {
                        rightSum += rightNumber % 10;
                        rightNumber /= 10;
                    }

                    Console.WriteLine(rightSum);
                }
            }

        }
    }
}
