using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._OldesFamilyMember
{
    class Program
    {
        static void Main(string[] args)
        {
            Family family = new Family();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] currentPerson = Console.ReadLine().Split();
                string name = currentPerson[0];
                int age = int.Parse(currentPerson[1]);

                Person person = new Person(name, age);
                family.AddMember(person);
            }

            var oldestMember = family.GetOldestMember();
            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }

        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Person(string name, int age)
            {
                this.Name = name;
                this.Age = age;
            }
        }
        public class Family
        {
            public List<Person> ListPersons { get; set; }
            public Family()
            {
                ListPersons = new List<Person>();
            }

            public void AddMember(Person currentPerson)
            {
                ListPersons.Add(currentPerson);
            }

            public Person GetOldestMember()
            {
                List<Person> ordList = ListPersons.OrderByDescending(a => a.Age).ToList();

                Person oldestMember = ordList[0];

                return oldestMember;
            }
        }
    }
}
