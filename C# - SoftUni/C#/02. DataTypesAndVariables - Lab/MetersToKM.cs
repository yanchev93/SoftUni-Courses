using System;

namespace _02._DataTypesAndVariables___Lab
{
    class MetersToKM
    {
        static void Main()
        {
            int meters = int.Parse(Console.ReadLine());
            decimal kilometers = meters / 1000.0m;
            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
