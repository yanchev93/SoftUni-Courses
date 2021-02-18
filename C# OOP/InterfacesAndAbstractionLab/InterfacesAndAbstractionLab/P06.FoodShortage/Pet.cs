namespace P06.FoodShortage
{
    public class Pet : IBirthday
    {
        private string name;

        public Pet(string name, string birthday)
        {
            this.name = name;
            this.Birthday = birthday;
        }
        public string Birthday { get; private set; }
    }
}
