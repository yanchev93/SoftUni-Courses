using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ListDepartments listEmployees = new ListDepartments();
            Dictionary<string, double> avrgSalary = new Dictionary<string, double>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ',
                    StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                double salaray = double.Parse(input[1]);
                string department = input[2];

                Employee currentEmployee = new Employee(name, salaray, department);
                if (!avrgSalary.ContainsKey(department))
                {
                    avrgSalary[department] = 0;
                }

                avrgSalary[department] += salaray;

                listEmployees.ListEmpolyees.Add(currentEmployee);
            }

            string highestDepartment = string.Empty;
            double highestAvrSalary = 0.00;

            foreach (var kvp in avrgSalary)
            {
                string currentDepartment = kvp.Key;
                double currentSalary = kvp.Value;

                if (currentSalary > highestAvrSalary)
                {
                    highestAvrSalary = currentSalary;
                    highestDepartment = currentDepartment;
                }
            }

            Console.WriteLine($"Highest Average Salary: {highestDepartment}");
            foreach (var departmentNames in listEmployees
                                            .ListEmpolyees
                                            .FindAll(d=>d.Department == highestDepartment)
                                            .OrderByDescending(x=>x.Salary))
            {
                string name = departmentNames.Name;
                double salary = departmentNames.Salary;
                Console.WriteLine($"{name} {salary:f2}");
            }
        }


        public class Employee
        {
            public string Name { get; set; }
            public double Salary { get; set; }
            public string Department { get; set; }
            public Employee(string name, double salary, string department)
            {
                this.Name = name;
                this.Salary = salary;
                this.Department = department;
            }
        }

        public class ListDepartments
        {
            public List<Employee> ListEmpolyees { get; set; }
            public ListDepartments()
            {
                ListEmpolyees = new List<Employee>();
            }
        }
    }
}
