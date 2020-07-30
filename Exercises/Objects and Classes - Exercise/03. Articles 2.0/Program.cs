using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfArticles = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < numberOfArticles; i++)
            {
                var input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

                articles.Add(new Article(input[0], input[1], input[2]));

            }

            string orderBy = Console.ReadLine();

            switch (orderBy)
            {
                case "title":

                    articles = articles.OrderBy(x => x.Title).ToList();

                    break;

                case "content":

                    articles = articles.OrderBy(x => x.Content).ToList();

                    break;

                case "author":

                    articles = articles.OrderBy(x => x.Author).ToList();

                    break;
            }

            Console.WriteLine(string.Join(Environment.NewLine, articles));
        }
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



    public override string ToString()
    {
        return $"{Title} - {Content}: {Author}";
    }
}
