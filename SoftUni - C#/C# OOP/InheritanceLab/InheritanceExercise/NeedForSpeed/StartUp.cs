using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main()
        {
            Vehicle raceMotorcycle = new RaceMotorcycle(100, 20);
            Vehicle crossMotorcycle = new CrossMotorcycle(100, 20);
            Vehicle familyCar = new FamilyCar(100, 20);
            Vehicle sportCar = new SportCar(100, 20);

            raceMotorcycle.Drive(5);
            crossMotorcycle.Drive(5);
            familyCar.Drive(5);
            sportCar.Drive(5);

            Console.WriteLine("RaceMotorcycle " + raceMotorcycle.Fuel);
            Console.WriteLine();

            Console.WriteLine("CrossMotorcycle " + crossMotorcycle.Fuel);
            Console.WriteLine();

            Console.WriteLine("FamilyCar " + familyCar.Fuel);
            Console.WriteLine();

            Console.WriteLine("SportCar " + sportCar.Fuel);
            Console.WriteLine();



        }
    }
}
