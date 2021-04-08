using System;
using System.Text;

namespace _01._ExtractPersonInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                StringBuilder age = new StringBuilder();
                StringBuilder name = new StringBuilder();

                int indexNameStart = input.IndexOf('@');
                int indexNameEnd = input.IndexOf('|');

                int length = indexNameEnd - indexNameStart - 1;
                name.Append(input.Substring(indexNameStart + 1, length));

                int indexAgeStart = input.IndexOf('#');
                int indexAgeEnd = input.IndexOf('*');

                length = indexAgeEnd - indexAgeStart - 1;
                age.Append(input.Substring(indexAgeStart + 1, length));

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
