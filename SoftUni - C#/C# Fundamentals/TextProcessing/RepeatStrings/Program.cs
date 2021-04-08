using System;
using System.Text;

namespace RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            StringBuilder sbOutput = new StringBuilder();

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    sbOutput.Append(words[i]);
                }
            }

            string output = sbOutput.ToString();

            Console.WriteLine(output);

        }
    }
}
