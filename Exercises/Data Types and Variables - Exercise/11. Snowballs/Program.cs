using System;
using System.Numerics;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {

            byte numberOfSnowballs = byte.Parse(Console.ReadLine());

            BigInteger bestSnowballValue = int.MinValue;
            short bestSnowballSnow = 0;
            short bestSnowballTime = 0;
            short bestSnowballQuality = 0;

            for (int i = 1; i <= numberOfSnowballs; i++)
            {
                short snowballSnow = short.Parse(Console.ReadLine());
                short snowballTime = short.Parse(Console.ReadLine());
                short snowballQuality = short.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                if (snowballValue > bestSnowballValue)
                {
                    bestSnowballValue = snowballValue;
                    bestSnowballSnow = snowballSnow;
                    bestSnowballTime = snowballTime;
                    bestSnowballQuality = snowballQuality;
                }
            }

            Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {bestSnowballValue} ({bestSnowballQuality})");

        }
    }
}
