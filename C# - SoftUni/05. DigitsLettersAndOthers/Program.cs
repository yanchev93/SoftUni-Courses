using System;
using System.Linq;
using System.Text;

namespace _05._DigitsLettersAndOthers
{
    class Program
    {
        static void Main()
        {

            string input = Console.ReadLine();

            StringBuilder letters = new StringBuilder();
            StringBuilder digits = new StringBuilder();
            StringBuilder others = new StringBuilder();


            for (int i = 0; i < input.Length; i++)
            {

                char chr = input[i];
                if (char.IsDigit(chr))
                {
                    digits.Append(chr);
                }
                else if (char.IsLetter(chr))
                {
                    letters.Append(chr);
                }
                else
                {
                    others.Append(chr);
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
    }
}
