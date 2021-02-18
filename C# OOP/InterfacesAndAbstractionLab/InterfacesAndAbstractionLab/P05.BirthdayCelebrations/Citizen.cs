namespace P05.BirthdayCelebrations
{
    public class Citizen : IId, IBirthday
    {
        private string name;

        private int age;

        public Citizen(string name, int age, string id, string birthday)
        {
            this.name = name;
            this.age = age;
            this.Id = id;
            this.Birthday = birthday;
        }

        public string Id { get; private set; }

        public string Birthday { get; private set; }
    }
}
