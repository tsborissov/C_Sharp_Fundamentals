using System;

namespace _10._SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {


            while (true)
            {
                string input = Console.ReadLine();
                if (input == "exam finished") { break; }

                string username = input.Split('-')[0];
                string language = input.Split('-')[1];
                int points = int.Parse(input.Split('-')[2]);



            }

        }
    }

    public class User
    {
        public string Username { get; set; }
        public string Language { get; set; }
        public int Points { get; set; }

        public User(string username, string language, int points)
        {
            this.Username = username;
            this.Language = language;
            this.Points = points;
        }
    }
}
