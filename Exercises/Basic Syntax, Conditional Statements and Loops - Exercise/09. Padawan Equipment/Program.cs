using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {

            double moneyTotal = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double lightsabrePrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double lightsabresCount = Math.Ceiling(studentsCount * 1.10);

            int beltsCount = studentsCount - studentsCount / 6;

            double priceTotal = lightsabresCount * lightsabrePrice + studentsCount * robePrice + beltsCount * beltPrice;

            double moneyDiff = moneyTotal - priceTotal;

            if (moneyDiff >= 0)
            {
                Console.WriteLine($"The money is enough - it would cost {priceTotal:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {Math.Abs(moneyDiff):F2}lv more.");
            }
        }
    }
}
