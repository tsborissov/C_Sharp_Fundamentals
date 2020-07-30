using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {

            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            double halfPower = pokePower * 1.0 / 2;

            int targetCounter = 0;

            while (pokePower >= distance)
            {
                if (pokePower == halfPower && exhaustionFactor != 0)
                {
                    pokePower /= exhaustionFactor;
                }

                pokePower -= distance;

                if (pokePower >= 0)
                {
                    targetCounter++;
                }
                else
                {
                    pokePower += distance;
                }
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(targetCounter);

        }
    }
}
