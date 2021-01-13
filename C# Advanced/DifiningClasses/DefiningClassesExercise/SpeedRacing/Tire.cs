namespace DefiningClasses
{
    public class Tire
    {
        // {tire1Pressure} {tire1Age} {tire2Pressure} {tire2Age} 
        // {tire3Pressure} {tire3Age} {tire4Pressure} {tire4Age}

        private int tireAge;
        private double tirePressure;

        public Tire(int tireAge, double tirePressure)
        {
            this.TireAge = tireAge;
            this.TirePressure = tirePressure;
        }

        public int TireAge
        {
            get { return this.tireAge; }
            set { this.tireAge = value; }
        }

        public double TirePressure
        {
            get { return this.tirePressure; }
            set { this.tirePressure = value; }
        }

    }
}
