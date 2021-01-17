using System;

namespace GenericScale
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 5;

            EqualityScale<int> equal = new EqualityScale<int>(a, b);

            var result = equal.AreEqual();
        }
    }
}
