using System;

namespace _03._Elevator
{
    class Elevator
    {
        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            decimal courses = persons / capacity;

            Console.WriteLine((courses));

        }
    }
}
