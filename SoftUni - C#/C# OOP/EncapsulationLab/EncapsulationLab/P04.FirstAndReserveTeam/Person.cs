using System;

namespace PersonsInfo
{
    public class Person
    {
        private const string VALIDATE_NAME = "{0} name cannot contain fewer than 3 symbols!";
        private const string FIRST_NAME = "First";
        private const string LAST_NAME = "Last";

        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                ValidateName(value, FIRST_NAME);

                this.firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                ValidateName(value, LAST_NAME);

                this.lastName = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }

                this.age = value;
            }
        }
        public decimal Salary
        {
            get
            {
                return this.salary;
            }
            private set
            {
                if (value < 460)
                {
                    throw new ArgumentException("Salary cannot be less than 460 leva!");
                }
                this.salary = value;
            }
        }

        public void IncreaseSalary(decimal percentage)
        {

            if (this.Age < 30)
            {
                percentage /= 2;
            }

            this.Salary += this.Salary * percentage / 100;
        }

        private static void ValidateName(string value, string name)
        {
            if (value.Length < 2)
            {
                throw new ArgumentException(string.Format(VALIDATE_NAME, name));
            }
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} receives {this.salary:f2} leva.";
        }
    }
}
