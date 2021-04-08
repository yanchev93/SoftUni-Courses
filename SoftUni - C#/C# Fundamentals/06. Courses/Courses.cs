using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    class Courses
    {
        static void Main()
        {
            Dictionary<string, List<string>> dictCourses = new Dictionary<string, List<string>>();


            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] currentCommand = command.Split(" : ").ToArray();

                string courseName = currentCommand[0];
                string studentName = currentCommand[1];

                if (!dictCourses.ContainsKey(courseName))
                {
                    dictCourses[courseName] = new List<string>();

                    dictCourses[courseName].Add(studentName);
                }
                else
                {
                    dictCourses[courseName].Add(studentName);
                }

                command = Console.ReadLine();
            }

            dictCourses = dictCourses
                          .OrderByDescending(x => x.Value.Count())
                          .ToDictionary(x => x.Key, x => x.Value);


            foreach (var kvp in dictCourses)
            {
                string courseName = kvp.Key;
                List<string> studentNames = kvp.Value;

                studentNames.Sort();

                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count()}");


                foreach (var student in studentNames)
                {
                    Console.WriteLine($"-- {student}");
                }                
            }    
        }
    }
}
