using System;

namespace _05.Decrypting_Messages
{
    class Program
    {
        static void Main(string[] args)
        {

            byte key = byte.Parse(Console.ReadLine());
            byte numberOfLines = byte.Parse(Console.ReadLine());

            string message = String.Empty;

            for (int i = 0; i < numberOfLines; i++)
            {
                char inputCharacter = char.Parse(Console.ReadLine());

                byte decodedCharacter = (byte)(inputCharacter + key);

                message += (char)decodedCharacter;
            }

            Console.WriteLine(message);

        }
    }
}
