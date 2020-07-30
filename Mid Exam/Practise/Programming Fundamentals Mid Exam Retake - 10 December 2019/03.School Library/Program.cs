using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.School_Library
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> books = Console.ReadLine()
                .Split('&')
                .ToList();

            string input = string.Empty;
            while((input = Console.ReadLine()) != "Done")
            {
                string[] commandWithParams = input.Split(" | ").ToArray();

                string command = commandWithParams[0];

                switch (command)
                {
                    case "Add Book":

                        string bookName = commandWithParams[1];

                        if (!books.Exists(x => x == bookName))
                        {
                            books.Insert(0, bookName);
                        }

                        break;

                    case "Take Book":

                        bookName = commandWithParams[1];

                        if (books.Exists(x => x == bookName))
                        {
                            books.Remove(bookName);
                        }

                        break;

                    case "Swap Books":

                        string book1 = commandWithParams[1];
                        string book2 = commandWithParams[2];

                        if (books.Exists(x => x == book1) && books.Exists(x => x == book2))
                        {
                            int index1 = books.IndexOf(book1);
                            int index2 = books.IndexOf(book2);

                            string tempBook = books[index1];
                            books[index1] = books[index2];
                            books[index2] = tempBook;
                        }

                        break;

                    case "Insert Book":

                        bookName = commandWithParams[1];

                        books.Add(bookName);

                        break;

                    case "Check Book":

                        int indexToCheck = int.Parse(commandWithParams[1]);

                        if (indexToCheck >= 0 && indexToCheck < books.Count)
                        {
                            Console.WriteLine(books[indexToCheck]);
                        }

                        break;
                }
            }

            Console.WriteLine(string.Join(", ", books));

        }
    }
}
