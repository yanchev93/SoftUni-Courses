using System;

namespace DemoForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string pass = "";

            for (int i = password.Length - 1; i >= 0; i--)
            {
                pass += password[i];
            }
            Console.WriteLine(pass);
        }
    }
}
