using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._FilterByAge
{
    class StartUp
    {
        static void Main()
        {
            List<Person> listPersons = new List<Person>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {

                var inputPerson = Console.ReadLine().Split(", ",
                    StringSplitOptions.RemoveEmptyEntries);
                string name = inputPerson[0];
                int age = int.Parse(inputPerson[1]);
                var person = new Person(name, age);

                listPersons.Add(person);
            }

            string condition = Console.ReadLine();
            int conditionAge = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();


            Func<Person, bool> func = f => true;

            if (condition == "younger")
            {
                func = p => p.Age < conditionAge;
            }
            else if (condition == "older")
            {
                func = p => p.Age >= conditionAge;
            }

            var printPersons = listPersons.Where(func);

            foreach (var person in printPersons)
            {
                if (format == "name age")
                {
                    Console.WriteLine($"{person.Name} - {person.Age}");
                }
                else if (format == "name")
                {
                    Console.WriteLine(person.Name);
                }
                else if (format == "age")
                {
                    Console.WriteLine(person.Age);
                }
            }
        }

        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public Person(string name, int age)
            {
                this.Name = name;
                this.Age = age;
            }
        }
    }
}
