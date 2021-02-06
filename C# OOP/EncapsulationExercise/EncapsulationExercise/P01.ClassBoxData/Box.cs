using System;
using System.Text;

namespace P01.ClassBoxData
{
    public class Box
    {
        private const string ERROR_MESSAGE = "{0} cannot be zero or negative.";

        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get
            {
                return this.length;
            }
            set
            {
                ValidateInput(value, nameof(Length));

                this.length = value;
            }
        }
        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                ValidateInput(value, nameof(Width));

                this.width = value;
            }
        }
        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                ValidateInput(value, nameof(Height));

                this.height = value;
            }
        }

        public double CalculateSurfaceArea()
        {
            double surfaceArea = (2 * (this.Length * this.Width))
                + CalculateLateralSurfaceArea();

            return surfaceArea;
        }
        public double CalculateLateralSurfaceArea()
        {
            double lateralSurfaceArea = 2 * ((this.Length * this.Height)
                + (this.Width * this.Height));

            return lateralSurfaceArea;
        }
        public double CalculateVolume()
        {
            double volume = this.Length * this.Width * this.Height;

            return volume;
        }
        private void ValidateInput(double value, string property)
        {
            if (value < 0)
            {
                throw new ArgumentException(string.Format(ERROR_MESSAGE, property));
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb
                .AppendLine($"Surface Area - {CalculateSurfaceArea():f2}")
                .AppendLine($"Lateral Surface Area - {CalculateLateralSurfaceArea():f2}")
                .AppendLine($"Volume - {CalculateVolume():f2}");

            return sb.ToString().TrimEnd();
        }
    }
}
