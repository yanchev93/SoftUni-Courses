using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] engineInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                InputDataEngine(engineInfo, engines);
            }

            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                string[] carInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                InputDataCar(carInfo, cars, engines);
            }

            Console.WriteLine(string.Join(Environment.NewLine, cars));
        }

        private static void InputDataCar(string[] info, List<Car> cars, List<Engine> engines)
        {
            string model = info[0];
            string engine = info[1];
            Engine findEngine = engines.Find(p => p.Model == engine);

            if(info.Length == 2)
            {
                Car car = new Car(model, findEngine);

                cars.Add(car);
            }
            else if (info.Length == 3)
            {
                int weight;

                bool isWeight = int.TryParse(info[2], out weight);

                if (isWeight)
                {
                    weight = int.Parse(info[2]);

                    Car car = new Car(model, findEngine, weight);

                    cars.Add(car);
                }
                else
                {
                    string color = info[2];

                    Car car = new Car(model, findEngine, color);

                    cars.Add(car);
                }
            }
            else if (info.Length == 4)
            {
                int weight = int.Parse(info[2]);
                string color = info[3];

                Car car = new Car(model, findEngine, weight, color);

                cars.Add(car);
            }
        }

        private static void InputDataEngine(string[] info, List<Engine> engines)
        {
            string model = info[0];
            int power = int.Parse(info[1]);

            if (info.Length == 2)
            {
                Engine engine = new Engine(model, power);

                engines.Add(engine);
            }
            else if (info.Length == 3)
            {
                int displacement;

                bool isDisplacement = int.TryParse(info[2], out displacement);

                if (isDisplacement)
                {
                    Engine engine = new Engine(model, power, displacement);

                    engines.Add(engine);
                }
                else
                {
                    string efficiency = info[2];

                    Engine engine = new Engine(model, power, efficiency);

                    engines.Add(engine);
                }
            }
            else if (info.Length == 4)
            {
                int displacement = int.Parse(info[2]);
                string efficiency = info[3];

                Engine engine = new Engine(model, power, displacement, efficiency);

                engines.Add(engine);
            }
        }
    }
}
