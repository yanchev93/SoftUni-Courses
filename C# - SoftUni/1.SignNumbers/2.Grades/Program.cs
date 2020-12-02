using System;

namespace _2.Grades
{
    class Program
    {
        static void Main()
        {
            double grade = double.Parse(Console.ReadLine());
            Grade(grade);
        }

        static void Grade(double grade)
        {
            string output = string.Empty;

            if (2.00 <= grade && grade <= 2.99)
            {
                output = "Fail";
            }

            else if (3.00 <= grade && grade <= 3.49)
            {
                output = "Poor";
            }

            else if (3.50 <= grade && grade <= 4.49)
            {
                output = "Good";
            }

            else if (4.50 <= grade && grade <= 5.49)
            {
                output = "Very good";
            }

            else if (5.50 <= grade && grade <= 6.00)
            {
                output = "Excellent";
            }

            Console.WriteLine(output);
        }
    }
}
