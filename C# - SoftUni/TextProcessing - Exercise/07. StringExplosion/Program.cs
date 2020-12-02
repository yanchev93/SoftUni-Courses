using System;
using System.Text;

namespace _07._StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(StringExplode(input));
        }

        static StringBuilder StringExplode(string input)
        {
            StringBuilder output = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                char isItBomb = input[i];

                if (isItBomb == '>')
                {
                    output.Append('>');
                    i++;
                    string strengthExplosion = input[i].ToString();
                    int explosion = i + int.Parse(strengthExplosion);

                    for (int j = i; j < explosion; j++)
                    {
                        if (i == input.Length)
                        {
                            return output;
                        }

                        if (input[j] == '>')
                        {
                            output.Append('>');
                            explosion += int.Parse(input[j + 1].ToString()) + 1;
                        }

                        i++;
                    }
                    if (explosion != 0)
                    {
                        i--;
                    }
                }

                else
                {
                    output.Append(input[i]);
                }
            }

            return output;
        }
    }
}
