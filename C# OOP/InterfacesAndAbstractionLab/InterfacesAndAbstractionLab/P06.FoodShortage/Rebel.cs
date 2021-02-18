namespace P06.FoodShortage
{
    public class Rebel : IBuyer
    {
        private string name;

        private int age;

        private string group;

        public Rebel(string name, int age, string group)
        {
            this.Name = name;
            this.age = age;
            this.group = group;
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

        public int Food { get; private set; }

        public void BuyFood()
        {
            this.Food += 5;
        }
    }
}
