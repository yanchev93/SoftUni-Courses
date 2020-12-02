using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DictDepartment dictEmployee = new DictDepartment();
            ListDepartment listEmployee = new ListDepartment();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ',
                    StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                double salaray = double.Parse(input[1]);
                string department = input[2];

                Employee currentEmployee = new Employee(name, salaray, department);

                if (!dictEmployee.Dict.ContainsKey(department))
                {
                    dictEmployee.Dict.Add(department, listEmployee);
                }

                dictEmployee.Dict[department].Add(currentEmployee);

            }

            var highestAvrgSalary = dictEmployee.Dict
                .OrderByDescending(x => x.Value.OrderByDescending(x => x.Salary));

            int x = 0;

        }


        public class Employee
        {
            public string Name { get; set; }
            public double Salary { get; set; }
            public Employee(string name, double salary)
            {
                this.Name = name;
                this.Salary = salary;
            }
        }

        public class DictDepartment
        {
            public List<Employee> myList { get; set; } 
            public Dictionary<string, List<Employee>> Dict { get; set; }
            public DictDepartment()
            {
                myList = new List<Employee>();
                Dict = new Dictionary<string, List<Employee>>();
            }
        }

        public class ListDepartment
        {
            public List<Employee> ListEmployees { get; set; }
            public ListDepartment()
            {
                ListEmployees = new List<Employee>();
            }
        }

    }
}
