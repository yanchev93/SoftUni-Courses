using System;
using System.Collections.Generic;
using System.Text;

namespace _06._Wardrobe
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] clothes = Console.ReadLine().Split(" -> ",
                    StringSplitOptions.RemoveEmptyEntries);
                string color = clothes[0];
                string[] currentClothes = clothes[1].Split(',',
                    StringSplitOptions.RemoveEmptyEntries);

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe[color] = new Dictionary<string, int>();
                }

                var currentColor = wardrobe[color];
                foreach (var cloth in currentClothes)
                {
                    if (!currentColor.ContainsKey(cloth))
                    {
                        currentColor[cloth] = 0;
                    }

                    currentColor[cloth] += 1;
                }
            }

            string[] findCloth = Console.ReadLine().Split(' ',
                StringSplitOptions.RemoveEmptyEntries);
            string colorToFind = findCloth[0];
            string clothToFind = findCloth[1];

            var sbPrint = new StringBuilder();

            foreach (var (color, clothes) in wardrobe)
            {
                sbPrint.AppendLine($"{color} clothes:");

                foreach (var (cloth, total) in clothes)
                {
                    if (!(color == colorToFind && cloth == clothToFind))
                    {
                        sbPrint.AppendLine($"* {cloth} - {total}");
                    }

                    else
                    {
                        sbPrint.AppendLine($"* {cloth} - {total} (found!)");
                    }
                }
            }

            Console.WriteLine(sbPrint);
        }
    }
}
