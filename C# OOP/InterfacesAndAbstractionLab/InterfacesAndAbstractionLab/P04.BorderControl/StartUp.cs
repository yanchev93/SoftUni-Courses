using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.BorderControl
{

    public class StartUp
    {
        public static void Main()
        {
            List<IId> dataForEntries = new List<IId>();

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] currentCommand = command.Split(' ').ToArray();

                if (currentCommand.Length == 2)
                {
                    string model = currentCommand[0];
                    string id = currentCommand[1];

                    IId robot = new Robot(model, id);

                    dataForEntries.Add(robot);
                }
                else if (currentCommand.Length == 3)
                {
                    string name = currentCommand[0];
                    int age = int.Parse(currentCommand[1]);
                    string id = currentCommand[2];

                    IId citizen = new Citizen(name, age, id);

                    dataForEntries.Add(citizen);
                }

                command = Console.ReadLine();
            }

            string fakeId = Console.ReadLine();

            dataForEntries
                          .Where(d => d.Id.EndsWith(fakeId))
                          .Select(d => d.Id)
                          .ToList()
                          .ForEach(Console.WriteLine);
        }
    }
}
