using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakeryOpenning
{
    public class Bakery
    {
        private List<Employee> data;

        public Bakery()
        {
            this.data = new List<Employee>();
        }
        public Bakery(string name, int capacity)
            : this()
        {
            this.Name = name;
            this.Capacity = capacity;
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count
        {
            get
            {
                return this.data.Count;
            }
        }

        public void Add(Employee employee)
        {
            if (this.Capacity > this.data.Count)
            {
                this.data.Add(employee);
            }
        }
        public bool Remove(string name)
        {
            Employee employee = this.data.FirstOrDefault(e => e.Name == name);

            if (employee != null)
            {
                this.data.Remove(employee);

                return true;
            }

            return false;
        }

        public Employee GetOldestEmployee()
        {
            int oldest = 0;

            foreach (Employee employee in this.data)
            {
                if (oldest < employee.Age)
                {
                    oldest = employee.Age;
                }
            }

            Employee oldestEmployee = this.data.FirstOrDefault(e => e.Age == oldest);

            return oldestEmployee;
        }

        public Employee GetEmployee(string name)
        {
            return this.data.FirstOrDefault(e => e.Name == name);
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Employees working at Bakery {this.Name}:");

            foreach (Employee employee in this.data)
            {
                sb.AppendLine(employee.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
