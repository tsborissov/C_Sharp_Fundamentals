using System;

namespace _01._Extract_Person_Information
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();

                int nameStartIndex = text.IndexOf('@') + 1;
                int nameCount = text.IndexOf('|') - nameStartIndex;

                string name = text.Substring(nameStartIndex, nameCount);

                int ageStartIndex = text.IndexOf('#') + 1;
                int ageCount = text.IndexOf('*') - ageStartIndex;

                string age = text.Substring(ageStartIndex, ageCount);

                Console.WriteLine($"{name} is {age} years old.");
            }

        }
    }
}
