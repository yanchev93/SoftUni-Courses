using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace _05._NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);


            List<string> output = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                string demon = input[i];
                int health = 0;
                double sum = 0;

                StringBuilder alphabet = new StringBuilder();
                List<double> damage = new List<double>();
                List<char> symbol = new List<char>();


                for (int j = 0; j < demon.Length; j++)
                {
                    bool symbols = demon[j] == '*' || demon[j] == '/';

                    if (char.IsDigit(demon[j]) || demon[j] == '-' || demon[j] == '+' || demon[j] == '.')
                    {
                        StringBuilder number = new StringBuilder();

                        for (int k = j; k < demon.Length; k++)
                        {
                            if (char.IsDigit(demon[k]) || demon[k] == '.' || demon[k] == '-' || demon[k] == '+')
                            {
                                number.Append(demon[k]);
                                continue;
                            }
                            string num = number.ToString();

                            damage.Add(double.Parse(num));
                            j = k;
                            break;
                        }

                        j -= 1;
                    }

                    else if (symbols)
                    {
                        symbol.Add(demon[j]);
                    }

                    else //if (char.IsLetter(demon[j]))
                    {
                        alphabet.Append(demon[j]);
                    }

                }

                for (int j = 0; j < alphabet.Length; j++)
                {
                    health += alphabet[j];
                }

                sum = damage.Sum();

                for (int j = 0; j < symbol.Count; j++)
                {
                    if (symbol[j] == '*')
                    {
                        sum *= 2;
                    }

                    else
                    {
                        sum /= 2;
                    }
                }

                output.Add($"{demon} - {health} health, {sum:f2} damage");
            }

            output.Sort();

            Console.WriteLine(string.Join(Environment.NewLine, output));
        }
    }
}
