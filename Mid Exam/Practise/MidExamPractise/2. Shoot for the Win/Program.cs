using System;
using System.Linq;

namespace _2._Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targetValues = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int shotTargetsCounter = 0;

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                int index = int.Parse(command);

                if (index < 0 || index > targetValues.Length - 1)
                {
                    continue;
                }

                int shotTargetValue = targetValues[index];

                if (shotTargetValue == -1)
                {
                    continue;
                }

                targetValues[index] = -1;

                for (int i = 0; i < targetValues.Length; i++)
                {
                    if (targetValues[i] > shotTargetValue && targetValues[i] != -1)
                    {
                        targetValues[i] -= shotTargetValue;
                    }
                    else if (targetValues[i] <= shotTargetValue && targetValues[i] != -1)
                    {
                        targetValues[i] += shotTargetValue;
                    }
                }

                shotTargetsCounter++;
            }

            Console.WriteLine($"Shot targets: {shotTargetsCounter} -> {string.Join(' ', targetValues)}");
        }
    }
}
