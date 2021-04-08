using System;

namespace Methods
{
    class Program
    {
        static void Main()
        {
            int numbers = int.Parse(Console.ReadLine());
            SignNumbers(numbers);
        }

        static void SignNumbers(int numbers)
        {
            string output = string.Empty;

            if (numbers > 0)
            {
                output = $"The number {numbers} is positive.";
            }
            else if (numbers < 0)
            {
                output = $"The number {numbers} is negative.";
            }
            else if (numbers == 0)
            {
                output = $"The number {numbers} is zero.";
            }
           
            Console.WriteLine(output);
        }
    }
}
