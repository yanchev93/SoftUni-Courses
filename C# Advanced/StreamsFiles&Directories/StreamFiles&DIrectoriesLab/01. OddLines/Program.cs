using System;
using System.IO;

namespace _01._OddLines
{
    class Program
    {
        static void Main()
        {
            using var reader = new StreamReader("../../../Input.txt");
            using var write = new StreamWriter("../../../Output.txt");
            int count = 0;

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                if (count % 2 != 0)
                {
                    write.WriteLine(line);
                }

                count += 1;
            }
        }
    }
}
