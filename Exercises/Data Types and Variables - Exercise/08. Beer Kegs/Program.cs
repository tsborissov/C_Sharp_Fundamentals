using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {

            byte numberOfKegs = byte.Parse(Console.ReadLine());

            float biggestVolume = float.MinValue;
            string biggestKeg = String.Empty;

            for (byte i = 1; i <= numberOfKegs; i++)
            {
                string kegModel = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                float kegVolume = (float)(Math.PI * Math.Pow(radius, 2) * height);

                if (kegVolume > biggestVolume)
                {
                    biggestVolume = kegVolume;
                    biggestKeg = kegModel;
                }

            }

            Console.WriteLine(biggestKeg);
        }
    }
}
