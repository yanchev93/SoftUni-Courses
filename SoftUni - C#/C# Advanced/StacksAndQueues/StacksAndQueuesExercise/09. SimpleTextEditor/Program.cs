using System;
using System.Collections.Generic;
using System.Text;

namespace _09._BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder();
            Stack<string> undo = new Stack<string>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(' ',
                    StringSplitOptions.RemoveEmptyEntries);
                string instruction = command[0];

                if (instruction == "1")
                {
                    string addText = command[1];

                    undo.Push(text.ToString());
                    text.Append(addText);
                }

                else if (instruction == "2")
                {
                    int count = int.Parse(command[1]);

                    undo.Push(text.ToString());
                    text.Remove(text.Length - count, count);
                }

                else if (instruction == "3")
                {
                    int index = int.Parse(command[1]) - 1;

                    Console.WriteLine(text[index]);
                }

                else if (instruction == "4")
                {
                    text.Clear();
                    string lastText = undo.Pop();

                    text.Append(lastText);
                }
            }
        }
    }
}
