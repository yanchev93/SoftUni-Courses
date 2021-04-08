using System;
using System.Text;

namespace _05._MultiplyBigNum
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

            Console.WriteLine(BigNumberOutput(bigNum, num));
            
         }

        static StringBuilder BigNumberOutput(string bigNum, int num)
        {
            int keepInMind = 0;
            StringBuilder rlyBigNum = new StringBuilder();

            for (int i = bigNum.Length - 1; i >= 0; i--)
            {
                int charToNum = int.Parse(((char)bigNum[i]).ToString());
                int sum = 0;

                sum = charToNum * num + keepInMind;
                keepInMind = 0;

                if (sum > 9)
                {
                    keepInMind = sum / 10;
                    sum = sum % 10;
                }
               
                rlyBigNum.Append(sum);

            }

            if (keepInMind > 0)
            {
                rlyBigNum.Append(keepInMind);
            }

            StringBuilder output = new StringBuilder();
            for (int i = rlyBigNum.Length - 1; i >= 0; i--)
            {
                output.Append(rlyBigNum[i]);
            }

            return output;
        }
    }
}
