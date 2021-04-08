using System;
using System.IO;

namespace _05._SliceAFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using FileStream inputText = new FileStream("../../../sliceMe.txt", FileMode.Open);
            var parts = 4.0;
            var totalSize = new FileInfo("../../../sliceMe.txt").Length;
            var SizePerFile = (int)Math.Ceiling(totalSize / parts);

            for (int i = 1; i <= parts; i++)
            {
                using var newFile = new FileStream($"../../../newFile-{i}.txt", FileMode.Create);

                var buffer = new byte[SizePerFile];

                var readBytes = inputText.Read(buffer, 0, buffer.Length);
                newFile.Write(buffer, 0, readBytes);

            }
        }
    }
}
