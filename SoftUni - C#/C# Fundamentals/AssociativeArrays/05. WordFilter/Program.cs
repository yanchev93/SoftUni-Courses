using System;
using System.Linq;

namespace _05._WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split().ToList();

            Console.WriteLine(string.Join(Environment.NewLine, words.Where(x => x.Length % 2 == 0)));
        }
    }
}
