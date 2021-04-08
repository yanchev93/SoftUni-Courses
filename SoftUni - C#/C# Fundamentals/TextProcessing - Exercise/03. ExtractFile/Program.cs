using System;

namespace _03._ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('\\');


            string[] output = input[input.Length - 1].Split('.'); 
            
            Console.WriteLine($"File name: {output[0]}");
            Console.WriteLine($"File extension: {output[1]}");
        }
    }
}
