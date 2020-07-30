using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();

            double singlePrice = 0;

            switch (groupType)
            {
                case "Students":
                    switch (day)
                    {
                        case "Friday":
                            singlePrice = 8.45;
                            break;
                        case "Saturday":
                            singlePrice = 9.80;
                            break;
                        case "Sunday":
                            singlePrice = 10.46;
                            break;
                    }

                    if (groupSize >= 30)
                    {
                        singlePrice *= (1 - 0.15);
                    }

                    break;
                case "Business":
                    switch (day)
                    {
                        case "Friday":
                            singlePrice = 10.90;
                            break;
                        case "Saturday":
                            singlePrice = 15.60;
                            break;
                        case "Sunday":
                            singlePrice = 16;
                            break;
                    }

                    if (groupSize >= 100)
                    {
                        groupSize -= 10;
                    }

                    break;
                case "Regular":
                    switch (day)
                    {
                        case "Friday":
                            singlePrice = 15;
                            break;
                        case "Saturday":
                            singlePrice = 20;
                            break;
                        case "Sunday":
                            singlePrice = 22.50;
                            break;
                    }

                    if (groupSize >= 10 && groupSize <= 20)
                    {
                        singlePrice *= (1 - 0.05);
                    }

                    break;
            }

            double priceTotal = groupSize * singlePrice;

            Console.WriteLine($"Total price: {priceTotal:F2}");
        }
    }
}
