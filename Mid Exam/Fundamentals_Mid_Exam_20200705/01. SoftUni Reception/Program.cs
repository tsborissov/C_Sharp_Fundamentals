using System;

namespace _01._SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployeeEfficiency = int.Parse(Console.ReadLine());
            int secondEmployeeEfficiency = int.Parse(Console.ReadLine());
            int thirdEmployeeEfficiency = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());

            int efficiencyTotal = firstEmployeeEfficiency + secondEmployeeEfficiency + thirdEmployeeEfficiency;

            int neededHoursCounter = 0;

            while (studentsCount > 0)
            {
                neededHoursCounter++;

                if (!(neededHoursCounter % 4 == 0))
                {
                    studentsCount -= efficiencyTotal;
                }
            }

            Console.WriteLine($"Time needed: {neededHoursCounter}h.");
        }
    }
}
