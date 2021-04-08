namespace P06.FoodShortage
{
    public class Citizen : IId, IBirthday, IBuyer
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

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                this.name = value;
            }
        }

        public string Id { get; private set; }

        public string Birthday { get; private set; }

        public int Food { get; private set; }

        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}
