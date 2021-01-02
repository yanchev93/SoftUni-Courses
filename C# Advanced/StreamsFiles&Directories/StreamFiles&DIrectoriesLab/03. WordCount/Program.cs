using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._WordCount
{
    class Program
    {
        static void Main()
        {
            using var readerWords = new StreamReader("../../../words.txt");
            string words = readerWords.ReadLine().ToLower();
            List<string> inputWords = words.Split(' ',
                StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var dictWords = new Dictionary<string, int>();
            for (int i = 0; i < inputWords.Count; i++)
            {
                string word = inputWords[i];

                if (!dictWords.ContainsKey(word))
                {
                    dictWords[word] = 0;
                }
            }

            using var readerText = new StreamReader("../../../text.txt");
            string pattern = @"(?<words>[A-Za-z']+)";

            string currentLine = readerText.ReadLine().ToLower();
            while (currentLine != null)
            {
                MatchCollection matches = Regex.Matches(currentLine, pattern);
                foreach (var match in matches)
                {
                    string word = match.ToString();
                    if (dictWords.ContainsKey(word))
                    {
                        dictWords[word] += 1;
                    }
                }

                currentLine = readerText.ReadLine()?.ToLower();
            }

            dictWords = dictWords
                        .OrderByDescending(v => v.Value)
                        .ToDictionary(k => k.Key, v => v.Value);
            using var output = new StreamWriter("../../../Output.txt");
            foreach (var (word, count) in dictWords)
            {
                output.WriteLine($"{word} - {count}");
            }
        }
    }
}
