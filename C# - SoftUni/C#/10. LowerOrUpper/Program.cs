using System;

namespace _10._LowerOrUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            char chr = char.Parse(Console.ReadLine());

            if ('A' <= chr && chr <= 'Z')
            {
                Console.WriteLine("upper-case");
            }
            else if ('a' <= chr && chr <= 'z')
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
