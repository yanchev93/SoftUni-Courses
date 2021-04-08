using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            // List<string> output = ValidUsernames(input);


            Console.WriteLine(string.Join(Environment.NewLine, ValidUsernames(input)));
        }

        static List<string> ValidUsernames(string[] input)
        {
            int lengthUsernames = input.Length;
            List<string> output = new List<string>(); 

            for (int i = 0; i < lengthUsernames; i++)
            {
                int currentUsernameLength = input[i].Length;
                string word = input[i];
                bool isValid = false;

                if (3 <= currentUsernameLength && currentUsernameLength <= 16)
                {
                    for (int j = 0; j < word.Length; j++)
                    {
                        if (char.IsLetterOrDigit(word[j]) || word[j] == '-' || word[j] == '_')
                        {
                            isValid = true;
                            continue;
                        }

                        else
                        {
                            isValid = false;
                            break;
                        }
                    }
                }

                if (isValid)
                {
                    output.Add(word);
                }
            }

            return output;
        }
    }
}
