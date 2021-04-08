using System;

namespace _05._HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string titleInput = Console.ReadLine();
            string articleInput = Console.ReadLine();
            
            Console.WriteLine($"<h1>{Environment.NewLine}  {titleInput}{Environment.NewLine}</h1>");
            Console.WriteLine($"<article>{Environment.NewLine}  {articleInput}{Environment.NewLine}</article>");

            string div = Console.ReadLine();
            while (div != "end of comments")
            {
                Console.WriteLine($"<div>{Environment.NewLine}  {div}{Environment.NewLine}</div>");

                div = Console.ReadLine();
            }
        }
    }
}
