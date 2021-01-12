using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            var listFamily = new Family();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] person = Console.ReadLine().Split(' ',
                    StringSplitOptions.RemoveEmptyEntries);
                string name = person[0];
                int age = int.Parse(person[1]);

                Person currentPerson = new Person(name, age);

                listFamily.AddMember(currentPerson);
            }

            foreach (var member in listFamily.AgeOverThirty())
            {
                Console.WriteLine($"{member.Name} - {member.Age}");
            }
        }
    }
}
