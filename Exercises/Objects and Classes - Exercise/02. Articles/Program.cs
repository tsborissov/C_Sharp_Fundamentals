using System;
using System.Linq;

namespace _02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Article article = new Article(input[0], input[1], input[2]);

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                var command = Console.ReadLine()
                    .Split(": ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                switch (command[0])
                {
                    case "Edit":
                        article.Edit(command[1]);
                        break;

                    case "ChangeAuthor":
                        article.ChangeAuthor(command[1]);
                        break;

                    case "Rename":
                        article.Rename(command[1]);
                        break;
                }
            }

            Console.WriteLine(article.ToString());
        }
    }

    public class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title, string contetn, string author)
        {
            this.Title = title;
            this.Content = contetn;
            this.Author = author;
        }

        // Edit: {new content}"; "ChangeAuthor: {new author}"; "Rename: {new title}"

        public void Edit(string content)
        {
            this.Content = content;
        }

        public void ChangeAuthor(string author)
        {
            this.Author = author;
        }

        public void Rename(string title)
        {
            this.Title = title;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
