using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _02._LinenUmbers
{
    class StartUp
    {
        static void Main()
        {
            var file = File.ReadAllLines("../../../../Resource/text.txt");
            using var output = new StreamWriter("../../../Output.txt");

            int count = 1;
            foreach (var line in file)
            {
                var sb = new StringBuilder();
                int lettersCount = 0;
                int punctuationCount = 0;

                sb.Append($"Line {count}: ");
                sb.Append(line + ' ');

                for (int j = 0; j < line.Length; j++)
                {
                    if (char.IsLetter(line[j]))
                    {
                        lettersCount += 1;
                    }

                    else if (char.IsPunctuation(line[j]))
                    {
                        punctuationCount += 1;
                    }
                }

                sb.Append($"({lettersCount})({punctuationCount})");
                output.WriteLine(sb.ToString());
                count += 1;
            }

        }
    }
}
