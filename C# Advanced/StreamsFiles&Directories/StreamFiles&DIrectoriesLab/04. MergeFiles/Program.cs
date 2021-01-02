using System;
using System.IO;

namespace _04._MergeFiles
{
    class Program
    {
        static void Main()
        {
            using var readerOne = new StreamReader("../../../FileOne.txt");
            using var readerTwo = new StreamReader("../../../FileTwo.txt");

            using var writer = new StreamWriter("../../../Output.txt");
            string lineOne = readerOne.ReadLine();
            string lineTwo = readerTwo.ReadLine();
            while (true)
            {
                if (lineOne != null)
                {
                    writer.WriteLine(lineOne);
                }

                if (lineTwo != null)
                {
                    writer.WriteLine(lineTwo);
                }

                else if (lineOne == null && lineTwo == null)
                {
                    break;
                }

                lineOne = readerOne.ReadLine();
                lineTwo = readerTwo.ReadLine();
            }
        }
    }
}
