namespace Animals
{
    public interface IAnimal
    {
        public string Name { get; }

        public string FavoriteFood { get; }

        public string ExplainSelf();
    }
}
