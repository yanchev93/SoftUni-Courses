using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Articles2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var allArticles = new ListArticles();

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(", ",
                    StringSplitOptions.RemoveEmptyEntries);
                string title = command[0];
                string content = command[1];
                string author = command[2];

                Articles currentArticle = new Articles(title, content, author);

                allArticles.OrderedList.Add(currentArticle);
            }

            string insturciton = Console.ReadLine();

            if (insturciton == "title")
            {
                foreach (var item in allArticles.OrderedList.OrderBy(t => t.Titel))
                {
                    Console.WriteLine($"{item.Titel} - {item.Content}: {item.Author}");
                }
            }

            else if (insturciton == "content")
            {
                foreach (var item in allArticles.OrderedList.OrderBy(c => c.Content))
                {
                    Console.WriteLine($"{item.Titel} - {item.Content}: {item.Author}");
                }
            }

            else if (insturciton == "author")
            {
                foreach (var item in allArticles.OrderedList.OrderBy(a => a.Author))
                {
                    Console.WriteLine($"{item.Titel} - {item.Content}: {item.Author}");
                }
            }
        }

        public class Articles
        {
            public string Titel { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

            public Articles(string title, string content, string author)
            {
                this.Titel = title;
                this.Content = content;
                this.Author = author;
            }
        }

        public class ListArticles
        {
            public List<Articles> OrderedList { get; set; }

            public ListArticles()
            {
                OrderedList = new List<Articles>();
            }
        }

    }
}
