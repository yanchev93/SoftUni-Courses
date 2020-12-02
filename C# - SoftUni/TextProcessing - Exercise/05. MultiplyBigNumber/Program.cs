using System;
using System.Text;

namespace _05._MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigNum = Console.ReadLine().TrimStart('0');
            int num = int.Parse(Console.ReadLine());


            if (num == 0)
            {
                Console.WriteLine(0);
                return;
            }

            StringBuilder sb = new StringBuilder();

            int keepInMind = 0;
            for (int i = bigNum.Length -1; i >= 0; i--)
            {
                int currentNum = int.Parse(bigNum[i].ToString());
                int result = currentNum * num + keepInMind;
                keepInMind = 0;

                if (result > 9)
                {
                    keepInMind = result / 10;
                    result = result % 10;
                }

                sb.Append(result);
            }

            if (keepInMind != 0)
            {
                sb.Append(keepInMind);
            }

            StringBuilder output = new StringBuilder();

            for (int i = sb.Length - 1; i >= 0; i--)
            {
                output.Append(sb[i]);
            }

            Console.WriteLine(output);
         }
    }
}
