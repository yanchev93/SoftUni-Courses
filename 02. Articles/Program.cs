using System;

namespace _02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] articles = Console.ReadLine().Split(", ",
                StringSplitOptions.RemoveEmptyEntries);

            string title = articles[0];
            string content = articles[1];
            string author = articles[2];

            int n = int.Parse(Console.ReadLine());

            Article currentArticle = new Article(title, content, author);

            for (int i = 0; i < n; i++)
            {
                string[] currentCommand = Console.ReadLine().Split(": ",
                    StringSplitOptions.RemoveEmptyEntries);

                string instruction = currentCommand[0];
                string command = currentCommand[1];

                if (instruction == "Edit")
                {
                    currentArticle.Edit(command);
                }

                else if (instruction == "ChangeAuthor")
                {
                    currentArticle.ChangeAuthor(command);
                }

                else if (instruction == "Rename")
                {
                    currentArticle.Rename(command);
                }
            }

            Console.WriteLine(currentArticle.ToString());
        }

        public class Article
        {
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

            public Article(string title, string content, string author)
            {
                this.Title = title;
                this.Content = content;
                this.Author = author;
            }

            public void Edit(string newContent)
            {
                this.Content = newContent;
            }

            public void ChangeAuthor(string newAuthor)
            {
                this.Author = newAuthor;
            }
            
            public void Rename(string newTitle)
            {
                this.Title = newTitle;
            }

            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}"; 
            }
        }
    }
}
