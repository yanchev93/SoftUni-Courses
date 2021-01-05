using System;

namespace _01._ActionPoint
{
    class StartUp
    {
        static void Main()
        {
            Action<string> printAction = print => Console.WriteLine(print);

            string[] names = Console.ReadLine().Split(' ',
                StringSplitOptions.RemoveEmptyEntries);

            printAction(string.Join(Environment.NewLine, names));
        }
    }
}
