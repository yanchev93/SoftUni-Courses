using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            var input = Console.ReadLine();
            while (input != "End")
            {
                string[] currentInput = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = currentInput[0];
                string id = currentInput[1];
                int age = int.Parse(currentInput[2]);

                Person currentPerson = new Person(name, id, age);
                people.Add(currentPerson);

                input = Console.ReadLine();
            }

            foreach (var person in people.OrderBy(x=>x.Age))
            {
                Console.WriteLine(person.ToString());
            }
        }

        public class Person
        {
            public string Name { get; set; }
            public string ID { get; set; }
            public int Age { get; set; }

            public Person(string name, string id, int age)
            {
                this.Name = name;
                this.ID = id;
                this.Age = age;
            }
            public override string ToString()
            {
                return $"{Name} with ID: {ID} is {Age} years old.";
            }
        }

        public class ListPersons
        {
            public List<Person> People { get; set; }

            public ListPersons()
            {
                People = new List<Person>();
            }
        }
    }
}
