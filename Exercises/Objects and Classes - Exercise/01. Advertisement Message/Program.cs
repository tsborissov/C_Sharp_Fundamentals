﻿using System;

namespace _01._Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOfMessages = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfMessages; i++)
            {
                //AdvertisementMessage ad = new AdvertisementMessage();
                //Console.WriteLine(ad.MessageGenerator());
                
                
                Console.WriteLine(AdvertisementMessage.MessageGenerator());
            }

        }

    }

    public class AdvertisementMessage
    {

        public static string[] Phrases = new string[] {"Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category."
            , "Exceptional product.", "I can’t live without this product."};

        public static string[] Events = new string[] {"Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!"
            , "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"};

        public static string[] Authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

        public static string[] Cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };


        public static string MessageGenerator()
        {
            Random rand = new Random();

            string currentPhrase = Phrases[rand.Next(0, Phrases.Length)];
            string currentEvent = Events[rand.Next(0, Events.Length)];
            string currentAuthor = Authors[rand.Next(0, Authors.Length)];
            string currentCity = Cities[rand.Next(0, Cities.Length)];

            return $"{currentPhrase} {currentEvent} {currentAuthor} – {currentCity}.";

        }

    }
}
