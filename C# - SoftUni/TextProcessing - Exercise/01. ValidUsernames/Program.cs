using System;
using System.Collections.Generic;

namespace _01._ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");


            Console.WriteLine(string.Join(Environment.NewLine, ValidUsernames(usernames)));
        }

        static List<string> ValidUsernames(string[] usernames)
        {
            List<string> validUsernames = new List<string>();

            for (int i = 0; i < usernames.Length; i++)
            {
                string username = usernames[i];
                bool isValid = true;
                for (int j = 0; j < username.Length; j++)
                {
                    if (3 <= username.Length && username.Length <= 16)
                    {
                        if (!(username[j] == '-' || username[j] == '_' || char.IsLetterOrDigit(username[j])))
                        {
                            isValid = false;
                            break;
                        }
                    }
                    else
                    {
                        isValid = false;
                    }
                }

                if (isValid)
                {
                    validUsernames.Add(username);
                }
            }

            return validUsernames;
        }
    }
}
