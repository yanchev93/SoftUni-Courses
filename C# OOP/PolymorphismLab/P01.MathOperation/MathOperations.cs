namespace Operations
{
    public class MathOperations : IMathOperations
    {
        public int Add(int firstInput, int secondInput)
        {
            return firstInput + secondInput;
        }

        public double Add(double firstInput, double secondInput, double thirdInput)
        {
            return firstInput + secondInput + thirdInput;
        }

        public decimal Add(decimal firstInput, decimal secondInput, decimal thirdInput)
        {
            return firstInput + secondInput + thirdInput;
        }
    }
}
