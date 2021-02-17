namespace P04.BorderControl
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text;

    public class Engine
    {
        private List<ICitizen> citizens = new List<ICitizen>();

        private List<IRobot> robots = new List<IRobot>();

        public void Run()
        {

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] currentCommand = command.Split(' ');

                if (currentCommand.Length == 3)
                {
                    string name = currentCommand[0];

                    int age = int.Parse(currentCommand[1]);
                    string id = currentCommand[2];

                    ICitizen citizen = new Citizen(name, age, id);

                    citizens.Add(citizen);
                }
                else if (currentCommand.Length == 2)
                {
                    string model = currentCommand[0];
                    string id = currentCommand[1];

                    IRobot robot = new Robot(model, id);

                    robots.Add(robot);
                }

                command = Console.ReadLine();
            }

            string fakeID = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            foreach (var citizen in citizens)
            {
                string citizenID = citizen.Id;

                if (citizenID.Substring(citizenID.Length - 3) == fakeID)
                {
                    sb.AppendLine(citizenID);
                }
            }

            foreach (var robot in robots)
            {
                string robotID = robot.Id;

                if (robotID.Substring(robotID.Length -3) == fakeID)
                {
                    sb.AppendLine(robotID);
                }
            }

            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
