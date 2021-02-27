namespace P02.VehiclesExtension
{
    using Core;
    using P02.VehiclesExtension.Core.Contracts;

    public class StartUp
    {
        public static void Main()
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
