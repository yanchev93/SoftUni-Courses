namespace Tuple
{
    using System;

    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string firstName = firstInput[0];
            string secondName = firstInput[1];
            string address = firstInput[2];
            string fullName = firstName + " " + secondName;

            string[] secondInput = Console.ReadLine()
                .Split();
            string name = secondInput[0];
            int litersBeer = int.Parse(secondInput[1]);

            string[] thirdInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int integer = int.Parse(thirdInput[0]);
            double myDouble = double.Parse(thirdInput[1]);

            var firstOutput = new MyTuple<string, string>(fullName, address);
            var secondOutput = new MyTuple<string, int>(name, litersBeer);
            var thirdOutput = new MyTuple<int, double>(integer, myDouble);

            Console.WriteLine(firstOutput);
            Console.WriteLine(secondOutput);
            Console.WriteLine(thirdOutput);
        }
    }
}
