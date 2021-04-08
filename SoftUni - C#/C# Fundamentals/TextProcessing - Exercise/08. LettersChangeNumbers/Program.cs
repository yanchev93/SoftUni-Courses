using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            List<double> listNums = new List<double>();

            // A12b s17G
            // 12/1=12, 12+2=14, 17*19=323, 323–7=316, 14+316=330

            for (int i = 0; i < input.Length; i++)
            {
                string currentCase = input[i];
                double sum = 0.00;                
                double num = int.Parse(currentCase.Substring(1, currentCase.Length - 2));


                int alphabetPosition = FirstLetter(currentCase[0]);
                if (char.IsUpper(currentCase[0]))
                {
                    sum += (num / alphabetPosition);
                }
                else
                {
                    sum += (num * alphabetPosition);
                }


                alphabetPosition = LastLetter(currentCase[currentCase.Length - 1]);
                if (char.IsUpper(currentCase[currentCase.Length - 1]))
                {
                    sum -= alphabetPosition;
                }

                else
                {
                    sum += alphabetPosition;
                }

                listNums.Add(sum);
            }

            double output = Math.Round(listNums.Sum(), 2);

            Console.WriteLine($"{output:f2}");
        }
        static int FirstLetter(char chr)
        {
            int alphabetPosition = 0;
            if (char.IsUpper(chr))
            {
                alphabetPosition = chr - 64;
            }
            else
            {
                alphabetPosition = chr - 96;
            }

            return alphabetPosition;
        }

        static int LastLetter(char chr)
        {
            int alphabetPosition = 0;
            if (char.IsUpper(chr))
            {
                alphabetPosition = chr - 64;
            }
            else
            {
                alphabetPosition = chr - 96;
            }

            return alphabetPosition;
        }
    }
}
