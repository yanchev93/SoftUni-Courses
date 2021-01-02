using System;
using System.IO;

namespace _02._LineNumbers
{
    class Program
    {
        static void Main()
        {
            using var reader = new StreamReader("../../../Input.txt");
            using var writer = new StreamWriter("../../../Output.txt");

            int count = 1;
            string currentLine = reader.ReadLine();
            while (currentLine != null)
            {
                writer.WriteLine($"{count}. {currentLine}");
                count += 1;

                currentLine = reader.ReadLine();
            }
        }
    }
}
