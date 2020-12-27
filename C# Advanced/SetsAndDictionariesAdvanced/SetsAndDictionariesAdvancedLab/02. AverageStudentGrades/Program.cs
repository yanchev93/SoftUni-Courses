using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02._AverageStudentGrades
{
    class Program
    {
        static void Main()
        {
            var studentGrades = new Dictionary<string, List<decimal>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ',
                    StringSplitOptions.RemoveEmptyEntries);
                string nameStudent = input[0];
                decimal currentGrade = decimal.Parse(input[1]);

                if (!studentGrades.ContainsKey(nameStudent))
                {
                    studentGrades[nameStudent] = new List<decimal>();
                }

                studentGrades[nameStudent].Add(currentGrade);
            }

            foreach (var (student, grades) in studentGrades)
            {
                var allGrades = new StringBuilder();
                foreach (var grade in grades)
                {
                    allGrades.Append($"{grade:f2} ");
                }

                Console.WriteLine($"{student} -> {allGrades}(avg: {grades.Average():f2})");
            }
        }
    }
}
