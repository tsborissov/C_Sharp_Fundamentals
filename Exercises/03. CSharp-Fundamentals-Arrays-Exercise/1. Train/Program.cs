using System;

namespace _1._Train
{
    class Program
    {
        static void Main(string[] args)
        {

            int countOfWagons = int.Parse(Console.ReadLine());

            int[] numberOfPeople = new int[countOfWagons];

            for (int i = 0; i < countOfWagons; i++)
            {
                numberOfPeople[i] = int.Parse(Console.ReadLine());
            }

            int sumOfPeople = 0;

            for (int j = 0; j < countOfWagons; j++)
            {
                sumOfPeople += numberOfPeople[j];
                Console.Write(numberOfPeople[j] + " ");
            }

            Console.WriteLine();
            Console.WriteLine(sumOfPeople);
        }
    }
}
