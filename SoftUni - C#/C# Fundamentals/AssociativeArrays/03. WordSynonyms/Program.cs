using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _03._WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            var dictSynonyms = new Dictionary<string, List<string>>();

            for (int i = 0; i < number; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!dictSynonyms.ContainsKey(word))
                {
                    dictSynonyms[word] = new List<string>();
                }

                dictSynonyms[word].Add(synonym);
            }

            Console.WriteLine(string.Join(Environment.NewLine, dictSynonyms.Select(x=>$"{x.Key} - {string.Join(", ", x.Value)}")));
        }
    }
}
