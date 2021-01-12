using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> people;

        public Family()
        {
            this.people = new List<Person>();
        }
        public List<Person> People
        {
            get { return this.people; }
            set { this.people = value; }
        }
        public  void AddMember(Person member)
        {
            this.people.Add(member);
        }

        public Person GetOldestMember()
        {
            Person oldestPerson = people.First();

            foreach (var member in people)
            {
                if (oldestPerson.Age < member.Age)
                {
                    oldestPerson = member;
                }
            }

            return oldestPerson;
        }
    }
}
