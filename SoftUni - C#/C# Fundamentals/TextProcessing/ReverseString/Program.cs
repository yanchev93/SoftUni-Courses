using System;
using System.Text;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                StringBuilder sbOutput = new StringBuilder();

                for (int i = command.Length - 1; i >= 0; i--)
                {
                    sbOutput.Append(command[i]);
                }

                string output = sbOutput.ToString();
                Console.WriteLine($"{command} = {output}");
            }
        }
    }
}
