using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._StudentAcademy
{
    class StudentAcademy
    {
        static void Main()
        {
            int countStudents = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> studentBook = new Dictionary<string, List<double>>();

            for (int i = 0; i < countStudents; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());

                if (!studentBook.ContainsKey(studentName))
                {
                    studentBook[studentName] = new List<double>();
                }

                studentBook[studentName].Add(studentGrade);

            }

            studentBook = studentBook
                          .Where(x => x.Value.Average() >= 4.50)
                          .OrderByDescending(x => x.Value.Average())
                          .ToDictionary(x => x.Key, x => x.Value);

            foreach (var student in studentBook)
            {
                string name = student.Key;
                List<double> grade = student.Value;


                Console.WriteLine($"{name} -> {grade.Average():f2}");

            }
        }
    }
}
