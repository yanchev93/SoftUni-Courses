using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._StudentsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new ListStudents();
            
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string firstName = input[0];
                string lastName = input[1];
                double grade = double.Parse(input[2]);

                Students currentStudent = new Students(firstName, lastName, grade);
                students.studentList.Add(currentStudent);
            }

            foreach (var student in students.studentList.OrderByDescending(s=>s.Grade))
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }

        public class Students
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double Grade { get; set; }

            public Students(string firstName, string lastName, double grade)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
                this.Grade = grade;
            }
        }

        public class ListStudents
        {
            public List<Students> studentList { get; set; }

            public ListStudents()
            {
                this.studentList = new List<Students>();
            }
        }
    }
}
