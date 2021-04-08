using System;
using System.Text;

namespace _02._RepeatString
{
    class RepeatString
    {
        static void Main()
        {
            string[] words = Console.ReadLine()
                             .Split();
            StringBuilder printMe = new StringBuilder();

            for (int i = 0; i < words.Length; i++)
            {
                for (int k = 0; k < words[i].Length; k++)
                {
                    printMe.Append(words[i]);
                }
            }

            Console.WriteLine(printMe.ToString());
        }
    }
}
