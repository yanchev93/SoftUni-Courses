using System;

namespace _03._ExtracrFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('\\');
            string[] lastIndex = input[input.Length - 1].Split('.');

            Console.WriteLine($"File name: {lastIndex[0]}");
            Console.WriteLine($"File extension: {lastIndex[1]}");
        }
    }
}
