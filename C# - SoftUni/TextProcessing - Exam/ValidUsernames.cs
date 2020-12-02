using System;

namespace TextProcessing___Exam
{
    class ValidUsernames
    {
        static void Main()
        {
            string[] username = Console.ReadLine().Split(", ");

            for (int i = 0; i < username.Length; i++)
            {
                string currentUser = username[i];
                bool isNotValide = false;
                if (3 <= currentUser.Length && currentUser.Length <= 16)
                {
                    for (int j = 0; j < currentUser.Length; j++)
                    {
                        char chr = currentUser[j];
                        if (char.IsLetterOrDigit(chr) || chr == '-' || chr == '_')
                        {
                            continue;
                        }
                        else
                        {
                            isNotValide = true;
                            break;
                        }
                    }
                }

                else
                {
                    continue;
                }

                if (isNotValide)
                {
                    continue;
                }

                else
                {
                    Console.WriteLine(currentUser);
                }
            }
        }
    }
}
