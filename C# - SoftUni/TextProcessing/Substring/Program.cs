using System;
using System.Text;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string remove = Console.ReadLine().ToLower();
            string input = Console.ReadLine().ToLower();

            StringBuilder sbOutput = new StringBuilder();
            string output = string.Empty;

            while (true)
            {
                int startIndex = input.IndexOf(remove);
                int lastIndex = remove.Length;

                input = (input.Remove(startIndex, lastIndex));

                if (!input.Contains(remove))
                {
                    break;
                }
            }

            Console.WriteLine(input);
        }
    }
}
