using System;
using System.Xml.Schema;

namespace _10.MultiplyEvenByOdds
{
    class Program
    {
        static void Main()
        {
            string givenNumber = Console.ReadLine();
            string output = string.Empty;

            if (givenNumber[0] == '-')
            {
                output = Minus(givenNumber);
            }
            else
            {
                output = Plus(givenNumber);
            }
            
            Console.WriteLine(output);
        }

        static string Minus(string givenNumber)
        {
            int evenSum = 0;
            int oddSum = 0;

            for (int i = 1; i < givenNumber.Length; i++)
            {
                int number = int.Parse(givenNumber[i].ToString());
                if (number % 2 == 0)
                {
                    evenSum += number;
                }
                else
                {
                    oddSum += number;
                }
            }     
            
            int total = evenSum * oddSum;
            return total.ToString();
        }

        static string Plus(string givenNumber)
        {
            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < givenNumber.Length; i++)
            {
                int number = int.Parse(givenNumber[i].ToString());
                if (number % 2 == 0)
                {
                    evenSum += number;
                }
                else
                {
                    oddSum += number;
                }
            }

            int total = evenSum * oddSum;
            return total.ToString();
        }
    }
}
