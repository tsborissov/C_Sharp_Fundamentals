using System;

namespace quizz
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = a++;

            Console.WriteLine($"a -> {a}, b -> {b}");

            int c = ++a;

            Console.WriteLine($"a -> {a}, c -> {c}");
        }
    }
}
