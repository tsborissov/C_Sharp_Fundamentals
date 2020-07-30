using System;

namespace _01._Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {

            int studentsCount = int.Parse(Console.ReadLine());
            int lecturesCount = int.Parse(Console.ReadLine());
            int additionalBonus = int.Parse(Console.ReadLine());

            double maxBonusPoints = 0;
            int maxStudentAttendance = 0;

            for (int i = 0; i < studentsCount; i++)
            {
                int attendancesCount = int.Parse(Console.ReadLine());

                double totalBonus = attendancesCount * 1.0 / lecturesCount * (5 + additionalBonus);

                if (totalBonus > maxBonusPoints)
                {
                    maxBonusPoints = totalBonus;
                    maxStudentAttendance = attendancesCount;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonusPoints)}.");
            Console.WriteLine($"The student has attended {maxStudentAttendance} lectures.");

        }
    }
}
