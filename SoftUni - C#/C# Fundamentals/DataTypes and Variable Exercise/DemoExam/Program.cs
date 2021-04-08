using System;

namespace DemoExam
{
    class Program
    {
        static void Main(string[] args)
        {
            byte first = byte.Parse(Console.ReadLine());
            byte second = byte.Parse(Console.ReadLine());
            byte third = byte.Parse(Console.ReadLine());
            short students = short.Parse(Console.ReadLine());

            short hours = 0;
            short sumReception = (short)(first + second + third);

            while (true)
            {
                hours += 1;
                if (hours % 4 == 0)
                {
                    continue;
                }                
                students -= sumReception;
                if (students <= 0)
                {
                    break;
                }
            }
            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
