namespace Shapes
{
    public interface IShape
    {
        public abstract double CalculatePerimeter();

        public abstract double CalculateArea();

        public string Draw();
    }
}
