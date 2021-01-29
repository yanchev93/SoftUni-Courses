using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _01._EvenLines
{
    class StartUp
    {
        static void Main()
        {
            using var streamReader = new StreamReader("../../../../Resource/text.txt");
            List<string> listLines = new List<string>();

            int count = 0;
            while (!streamReader.EndOfStream)
            {
                var line = streamReader.ReadLine();

                if (count % 2 == 0)
                {
                    listLines.Add(line);
                }

                count += 1;
            }

            StringBuilder sb = new StringBuilder();

            foreach (var line in listLines)
            {
                string[] words = line.Split(' ',
                    StringSplitOptions.RemoveEmptyEntries);
                words = words.Reverse().ToArray();

                foreach (var word in words)
                {
                    for (int i = 0; i < word.Length; i++)
                    {

                        if (word[i] == '-' || word[i] == ',' ||
                            word[i] == '.' || word[i] == '!' || word[i] == '?')
                        {
                            sb.Append('@');
                        }
                        else
                        {
                            sb.Append(word[i]);
                        }
                    }

                    sb.Append(' ');
                }

                sb.AppendLine();
            }

            Console.WriteLine(sb.ToString().Trim());
        }
    }
}
