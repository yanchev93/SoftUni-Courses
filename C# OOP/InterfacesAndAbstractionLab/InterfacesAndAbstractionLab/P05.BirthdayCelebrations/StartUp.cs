namespace P05.BirthdayCelebrations
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            List<IBirthday> dataForBirthdays = new List<IBirthday>();

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] currentCommand = command.Split(' ').ToArray();
                string whoToCast = currentCommand[0];

                if (whoToCast == "Citizen")
                {
                    string name = currentCommand[1];
                    int age = int.Parse(currentCommand[2]);
                    string id = currentCommand[3];
                    string birthday = currentCommand[4];

                    IBirthday citizen = new Citizen(name, age, id, birthday);

                    dataForBirthdays.Add(citizen);
                }
                else if (whoToCast == "Pet")
                {
                    string name = currentCommand[1];
                    string birthday = currentCommand[2];

                    IBirthday pet = new Pet(name, birthday);

                    dataForBirthdays.Add(pet);
                }
                else if (whoToCast == "Robot")
                {
                    string model = currentCommand[1];
                    string id = currentCommand[2];

                }


                command = Console.ReadLine();
            }

            string birthYear = Console.ReadLine();

            dataForBirthdays.Where(d => d.Birthday.EndsWith(birthYear))
                .Select(d => d.Birthday)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
