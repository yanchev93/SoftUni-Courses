using System;
using System.Collections.Generic;
using System.Linq;

namespace Students2._0Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] currentCommand = command.Split();
                string firstname = currentCommand[0];
                string lastname = currentCommand[1];
                int age = int.Parse(currentCommand[2]);
                string hometown = currentCommand[3];


                Student student = students.FirstOrDefault(s => s.FirstName == firstname && s.LastName == lastname);
                if (student == null)
                {
                    Student currentStudent = new Student(firstname, lastname, age, hometown);
                    students.Add(currentStudent);
                }
                else
                {
                    student.FirstName = firstname;
                    student.LastName = lastname;
                    student.Age = age;
                    student.Hometown = hometown;
                }

                command = Console.ReadLine();
            }

            string townToPrint = Console.ReadLine();

            for (int i = 0; i < students.Count; i++)
            {
                Student student = students[i];

                if (townToPrint == student.Hometown)
                {
                    Console.WriteLine(student.ToString());
                }
            }
        }

        public class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string Hometown { get; set; }

            public Student(string firstName, string lastName, int age, string hometown)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
                this.Age = age;
                this.Hometown = hometown;
            }

            public override string ToString()
            {
                return $"{FirstName} {LastName} is {Age} years old.";
            }
        }
    }
}
