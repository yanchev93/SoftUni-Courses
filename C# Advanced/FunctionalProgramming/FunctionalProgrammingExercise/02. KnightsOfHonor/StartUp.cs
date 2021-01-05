using System;
using System.Linq;

namespace _01._ActionPoint
{
    class StartUp
    {
        static void Main()
        {
            Action<string> printAddSir = text => text
                .Split()
                .ToList()
                .ForEach(x => Console.WriteLine($"Sir {x}"));

            string output = Console.ReadLine();

            printAddSir(output);
        }
    }
}
