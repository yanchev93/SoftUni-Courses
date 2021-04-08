using System;

namespace TextProcessing___Lab
{
    class ReverseWord
    {
        static void Main()
        {
            string command = Console.ReadLine();
            while (command != "end")
            {

                Console.WriteLine($"{command} = {Reverse(command)}");
                command = Console.ReadLine();
            }
        }
        public static string Reverse(string word)
        {
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
