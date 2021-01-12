using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            Person person = new Person();
            person.Name = "Pesho";
            person.Age = 20;

            Console.WriteLine($"Hello, my name is {person.Name} and I am {person.Age} years old");
        }
    }
}
