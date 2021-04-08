using System;

namespace _02._CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split();

            string text1 = text[0];
            string text2 = text[1];

            int sum = 0;

            if (text.Length == 1)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    string currentText = text[i];
                    for (int j = 0; j < currentText.Length; j++)
                    {
                        sum += currentText[j];
                    }
                }

                Console.WriteLine(sum);
            }

            else
            {
                Console.WriteLine(CharecterCodeMultiplied(text1, text2));

            }
        }

        static int CharecterCodeMultiplied(string text1, string text2)
        {
            int sum = 0;
            string first = string.Empty;
            string second = string.Empty;

            if (text1.Length > text2.Length)
            {
                first = text1;
                second = text2;

                for (int i = 0; i < second.Length; i++)
                {
                    sum += first[i] * second[i];
                }

                for (int i = second.Length; i < first.Length; i++)
                {
                    sum += first[i];
                }

                return sum;
            }

            else
            {
                for (int i = 0; i < text1.Length; i++)
                {
                    sum += text1[i] * text2[i];
                }

                return sum;
            }
        }
    }
}
