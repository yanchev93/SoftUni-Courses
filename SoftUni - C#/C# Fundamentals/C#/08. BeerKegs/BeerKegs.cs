using System;

namespace _08._BeerKegs
{
    class BeerKegs
    {
        static void Main(string[] args)
        {
            int numberOfBeerKegs = int.Parse(Console.ReadLine());
            string bestModel = string.Empty;
            double bestVolume = 0;
            for (int i = 0; i < numberOfBeerKegs; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * radius * radius * height;

                if (volume > bestVolume)
                {
                    bestVolume = volume;
                    bestModel = model;
                }
            }
            Console.WriteLine(bestModel);
        }
    }
}
