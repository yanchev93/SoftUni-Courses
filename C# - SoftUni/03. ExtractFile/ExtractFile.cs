using System;

namespace _03._ExtractFile
{
    class ExtractFile
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('\\');
            string file = string.Empty;
            for (int i = input.Length - 1 ; i < input.Length ; i++)
            {
                file += input[i];
            }

            string[] output = file.Split('.');
            
            Console.WriteLine($"File name: {output[0]}");
            Console.WriteLine($"File extension: {output[1]}");
        }
    }
}
