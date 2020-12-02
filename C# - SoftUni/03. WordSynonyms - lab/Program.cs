using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._WordSynonyms___lab
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            var dict = WordSynonyms(num);
            
            Console.WriteLine(string.Join(Environment.NewLine, dict.Select(x => $"{x.Key} - {string.Join(", ", x.Value)}")));
        }

        static Dictionary<string, List<string>> WordSynonyms(int num)
        {
            var dict = new Dictionary<string, List<string>>();

            for (int i = 0; i < num; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                if (!dict.ContainsKey(word))
                {
                    dict[word] = new List<string>();
                }

                dict[word].Add(synonym);
            }

            return dict;
        }
    }
}
