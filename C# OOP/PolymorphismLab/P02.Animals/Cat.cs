namespace Animals
{
    public class Cat : Animal
    {
        public Cat(string name, string favoriteFood)
            : base(name, favoriteFood)
        {
            //this.Name = name;
            //this.FavoriteFood = favoriteFood;
        }

        public override string ExplainSelf()
        {
            return $"I am {this.Name} and my fovourite food is {this.FavoriteFood} MEEOW";
        }
    }
}
