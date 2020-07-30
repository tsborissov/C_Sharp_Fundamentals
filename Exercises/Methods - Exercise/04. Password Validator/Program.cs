using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {

            string password = Console.ReadLine();

            if (PasswordLenght(password) && LettersAndDigitsOnly(password) && AtLeastTwoDigits(password))
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (!PasswordLenght(password))
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }

                if (!LettersAndDigitsOnly(password))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }

                if (!AtLeastTwoDigits(password))
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }


        }

        static bool PasswordLenght(string password)

        {
            bool isValidLenght = false;

            if (password.Length >= 6 && password.Length <= 10)
            {
                isValidLenght = true;
            }

            return isValidLenght;
        }

        static bool LettersAndDigitsOnly(string password)
        {


            for (int i = 0; i < password.Length; i++)
            {
                if (!(password[i] >= 48 && password[i] <= 57 || password[i] >= 65 && password[i] <= 90 || password[i] >= 97 && password[i] <= 122))
                {
                    return false;
                }
            }

            return true;
        }

        static bool AtLeastTwoDigits(string password)
        {
            int digitsCounter = 0;
            bool isEnoughDigits = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 48 && password[i] <= 57)
                {
                    digitsCounter++;
                    if (digitsCounter == 2)
                    {
                        isEnoughDigits = true;
                        break;
                    }
                }
            }

            return isEnoughDigits;
        }
    }
}
