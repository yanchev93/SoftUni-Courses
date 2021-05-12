using System;
using System.Collections.Generic;
using System.Text;

namespace Work
{
    class Program
    {
        static void Main(string[] args)
        {
            // Acetate_67~Viscose_33
            // Acetate_67~Viscose_33
            List<string> output = new List<string>();
            int count = 770;
            while (count > 0)
            {
                count -= 1;
                var input = Console.ReadLine().Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

                StringBuilder sb = new StringBuilder();

                foreach (var item in input)
                {
                    string[] product = item.Split("~");
                    foreach (var material in product)
                    {
                        string[] currentMaterial = material.Split("_");
                        string name = currentMaterial[0];
                        double percent = double.Parse(currentMaterial[1]);

                        sb.Append($"{percent}% {name} ");
                    }
                    output.Add(sb.ToString().Trim());
                }
            }

            Console.WriteLine("--------------------------");
            Console.WriteLine("--------------------------");
            Console.WriteLine(string.Join(Environment.NewLine, output));


            // for (int i = 0; i < input.length; i++)
            // {
            //     if (charinput[i]))
            //     {
            // 
            // }
        }
    }
}

