using System;

namespace DefiningClasses
{
    public class Car
    {
        private string model;
        private Cargo cargo;
        private Engine engine;
        private Tire[] tires;

        public Car(string model, Cargo cargo, Engine engine, Tire[] tires)
        {
            Model = model;
            Cargo = cargo;
            Engine = engine;
            Tires = tires;
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public Cargo Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }
        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }

        public Tire[] Tires
        {
            get { return tires; }
            set { tires = value; }
        }


    }
}
