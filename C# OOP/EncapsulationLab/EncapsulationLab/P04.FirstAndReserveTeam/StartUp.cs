namespace PersonsInfo
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            Team team = new Team("SoftUni");
            int peopleCount = int.Parse(Console.ReadLine());
            var persons = new List<Person>();

            for (int i = 0; i < peopleCount; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                try
                {
                    var person = new Person(cmdArgs[0],
                                        cmdArgs[1],
                                        int.Parse(cmdArgs[2]),
                                        decimal.Parse(cmdArgs[3]));

                    persons.Add(person);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }

            foreach (Person person in persons)
            {
                team.AddPlayer(person);
            }

        }
    }
}
