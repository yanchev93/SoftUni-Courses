namespace ClassroomProject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Classroom
    {
        private List<Student> students;

        public Classroom()
        {
            this.students = new List<Student>();
        }
        public Classroom(int capacity)
            : this()
        {
            this.Capacity = capacity;
        }

        public int Capacity { get; set; }
        public int Count
        {
            get
            {
                return this.students.Count;
            }
        }

        public string RegisterStudent(Student student)
        {
            if (this.Capacity > this.students.Count)
            {
                this.students.Add(student);

                return $"Added student {student.FirstName} {student.LastName}";
            }

            return "No seats in the classroom";
        }

        public string DismissStudent(string firstName, string lastName)
        {
            Student student = this.students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);

            if (student != null)
            {
                return $"Dismissed student {student.FirstName} {student.LastName}";
            }

            return "Student not found";
        }

        public string GetSubjectInfo(string subject)
        {
            if (!this.students.Any(s=> s.Subject == subject))
            {
                return $"No students enrolled for the subject";
            }

            StringBuilder sb = new StringBuilder();

            sb
                .AppendLine($"Subject: {subject}")
                .AppendLine("Students:");

            foreach (Student student in students)
            {
                if (student.Subject == subject)
                {
                    sb.AppendLine($"{student.FirstName} {student.LastName}");
                }
            }

            return sb.ToString().TrimEnd();
        }

        public int GetStudentsCount()
        {
            return this.Count;
        }

        public Student GetStudent(string firstName, string lastName)
        {
            Student student = this.students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);

            return student;
        }



    }
}
