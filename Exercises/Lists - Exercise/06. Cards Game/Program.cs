using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> firstDeckCards = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondDeckCards = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (firstDeckCards.Count > 0 && secondDeckCards.Count > 0)
            {
                if (firstDeckCards[0] > secondDeckCards[0])
                {
                    FirstCardWins(firstDeckCards, secondDeckCards);
                }
                else if (firstDeckCards[0] == secondDeckCards[0])
                {
                    EqualCards(firstDeckCards, secondDeckCards);
                }
                else
                {
                    SecondCardWins(firstDeckCards, secondDeckCards);
                }
            }

            if (firstDeckCards.Count > 0)
            {
                Console.WriteLine($"First player wins! Sum: {firstDeckCards.Sum()}");
            }
            else if (secondDeckCards.Count > 0)
            {
                Console.WriteLine($"Second player wins! Sum: {secondDeckCards.Sum()}");
            }
        }

        static void FirstCardWins (List<int> firstDeckCards, List<int> secondDeckCards)
        {
            firstDeckCards.Add(firstDeckCards[0]);
            firstDeckCards.Add(secondDeckCards[0]);
            firstDeckCards.RemoveAt(0);
            secondDeckCards.RemoveAt(0);
        }

        static void SecondCardWins(List<int> firstDeckCards, List<int> secondDeckCards)
        {
            secondDeckCards.Add(secondDeckCards[0]);
            secondDeckCards.Add(firstDeckCards[0]);
            firstDeckCards.RemoveAt(0);
            secondDeckCards.RemoveAt(0);
        }

        static void EqualCards(List<int> firstDeckCards, List<int> secondDeckCards)
        {
            firstDeckCards.RemoveAt(0);
            secondDeckCards.RemoveAt(0);
        }
    }
}
