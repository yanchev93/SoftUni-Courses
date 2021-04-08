using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Child : Person
    {
        public Child(string name, int age)
            : base(name, age)
        {
        }

        public override int Age
        {
            get
            {
                return base.Age;
            }
            set
            {
                if (base.Age > 15)
                {
                    throw new ArgumentException("Children can't be more than 15 years old.");
                }

                base.Age = value;
            }
        }
    }
}
