﻿using System;

namespace Person
{
    public class StartUp
    {
        public static void Main()
        {
            try
            {
                string name = Console.ReadLine();
                int age = int.Parse(Console.ReadLine());

                Child child = new Child(name, age);
                Console.WriteLine(child);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
        }
    }
}