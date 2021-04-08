using System;
using System.Security.Cryptography;

namespace _08.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            float maxKegValue = float.MinValue;
            string biggestKegName = string.Empty;
            for (int i = 0; i < n; i++)
            {
                string modelName = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                float biggestKegValue = (float)(Math.PI * Math.Pow(radius, 2) * height);

                if (biggestKegValue > maxKegValue)
                {
                    maxKegValue = biggestKegValue;
                    biggestKegName = modelName;
                }
            }
            Console.WriteLine(biggestKegName);
            


        }
    }
}
