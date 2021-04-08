using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> employeesBook = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] currentCommand = command.Split(" -> ");

                string company = currentCommand[0];
                string employe = currentCommand[1];

                if (!employeesBook.ContainsKey(company))
                {
                    employeesBook[company] = new List<string>();
                }

                if (employeesBook[company].Contains(employe))
                {
                    command = Console.ReadLine();
                    continue;
                }

                employeesBook[company].Add(employe);


                command = Console.ReadLine();
            }

            employeesBook = employeesBook
                            .OrderBy(x => x.Key)
                            .ToDictionary(x => x.Key, x => x.Value);

            foreach (var employee in employeesBook)
            {
                string company = employee.Key;
                List<string> employees = employee.Value;

                Console.WriteLine($"{company}");

                foreach (var idNumber in employees)
                {
                    Console.WriteLine($"-- {idNumber}");
                }
            }
        }
    }
}
