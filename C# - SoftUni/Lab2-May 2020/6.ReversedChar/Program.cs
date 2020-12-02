using System;

namespace _6.ReversedChar
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());

            if ((int)('A') >= (char)a || (char)a <= (int)('Z'))
            {
                Console.WriteLine("upper-case");
            }
            else if ((int)('a') >= (char)a || (char)a <= (int)('z'))
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
