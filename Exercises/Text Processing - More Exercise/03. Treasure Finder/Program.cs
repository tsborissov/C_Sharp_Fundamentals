using System;
using System.Linq;
using System.Text;

namespace _03._Treasure_Finder
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] key = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (true)
            {
                string message = Console.ReadLine();
                if (message == "find") { break; }

                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < message.Length; i += key.Length)
                {
                    for (int j = 0; j < key.Length; j++)
                    {
                        if (i + j > message.Length - 1)
                        {
                            break;
                        }
                        sb.Append((char)(message[i + j] - key[j]));
                    }
                }

                string encryptedMessage = sb.ToString();

                int treasureIndex = encryptedMessage.IndexOf('&') + 1;
                int treasureCount = encryptedMessage.LastIndexOf('&') - treasureIndex;

                string treasure = encryptedMessage.Substring(treasureIndex, treasureCount);


                int coordinatesIndex = encryptedMessage.IndexOf('<') + 1;
                int coordinatesCount = encryptedMessage.IndexOf('>') - coordinatesIndex;

                string coordinates = encryptedMessage.Substring(coordinatesIndex, coordinatesCount);

                Console.WriteLine($"Found {treasure} at {coordinates}");
            }

        }
    }
}
