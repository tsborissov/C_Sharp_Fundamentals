using System;

namespace _05._Messages
{
    class Program
    {
        static void Main(string[] args)
        {

            int smsLenght = int.Parse(Console.ReadLine());

            string sms = String.Empty;

            for (int i = 0; i < smsLenght; i++)
            {
                int keyboardInput = int.Parse(Console.ReadLine());

                int numberOfDigits = (keyboardInput.ToString()).Length;
                int mainDigit = 0;
                int offset = 0;

                if (numberOfDigits == 1)
                {
                    mainDigit = keyboardInput;
                }
                else if (numberOfDigits == 2)
                {
                    mainDigit = keyboardInput / 10;
                }
                else if (numberOfDigits ==3)
                {
                    mainDigit = keyboardInput / 100;
                }
                else
                {
                    mainDigit = keyboardInput / 1000;
                }
                
                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset = (mainDigit - 2) * 3 + 1;
                }
                else
                {
                    offset = (mainDigit - 2) * 3;
                }

                int letterIndex = offset + numberOfDigits - 1;

                if (letterIndex == -6)
                {
                    letterIndex = -65;
                }

                char letter = (char)(letterIndex + 97);

                sms += letter;

            }

            Console.WriteLine(sms);
        }
    }
}
