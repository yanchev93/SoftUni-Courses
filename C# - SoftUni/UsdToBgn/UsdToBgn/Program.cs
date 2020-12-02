using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Serialization;

namespace UsdToBgn
{
    class Program
    {
        static void Main(string[] args)
        {
            double rentHall = double.Parse(Console.ReadLine());

            double cake = rentHall * 0.20;
            double drinks = cake - (cake * 0.45);
            double animator = rentHall / 3;

            double result = rentHall + cake + drinks + animator;
            Console.WriteLine(result);

        }
    }
}
