using System;

namespace _01._Experience_Gaining
{
    class Program
    {
        static void Main(string[] args)
        {

            double neededExperience = double.Parse(Console.ReadLine());
            int expectedBattlesCount = int.Parse(Console.ReadLine());

            double experienceGained = 0;
            int battlesCount = 0;

            for (int i = 1; i <= expectedBattlesCount; i++)
            {
                double experiencePerBattle = double.Parse(Console.ReadLine());

                if (i % 3 == 0)
                {
                    experiencePerBattle += experiencePerBattle * 0.15;
                }

                if (i % 5 == 0)
                {
                    experiencePerBattle -= experiencePerBattle * 0.10;
                }

                experienceGained += experiencePerBattle;

                battlesCount++;

                if (experienceGained >= neededExperience)
                {
                    Console.WriteLine($"Player successfully collected his needed experience for {battlesCount} battles.");
                    break;
                }

            }

            if (experienceGained < neededExperience)
            {
                Console.WriteLine($"Player was not able to collect the needed experience, {(neededExperience - experienceGained):F2} more needed.");
            }

        }
    }
}
