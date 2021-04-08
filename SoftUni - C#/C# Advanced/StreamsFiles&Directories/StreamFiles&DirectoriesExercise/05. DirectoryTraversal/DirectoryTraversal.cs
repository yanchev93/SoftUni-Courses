using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _05._DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileInfo = new Dictionary<string, Dictionary<string, double>>();

            DirectoryInfo directoryInfo = new DirectoryInfo("../../../");
            FileInfo[] files = directoryInfo.GetFiles();

            foreach (var file in files)
            {
                if (!fileInfo.ContainsKey(file.Extension))
                {
                    fileInfo.Add(file.Extension, new Dictionary<string, double>());
                }

                fileInfo[file.Extension].Add(file.Name, file.Length);
            }

            using (StreamWriter writer = new StreamWriter(@$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\DirectoryTraverasl.txt"))
            {

                foreach (var item in fileInfo.OrderByDescending(f => f.Value.Count).ThenBy(i => i.Key))
                {
                    writer.WriteLine(item.Key);
                    foreach (var file in item.Value.OrderByDescending(i => i.Value))
                    {
                        writer.WriteLine($"--{file.Key} - {file.Value}kb");
                    }
                }

            }

        }
    }
}
