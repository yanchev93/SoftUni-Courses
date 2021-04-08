namespace Threeuple
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
            string town = firstInput[3];
            string fullName = firstName + " " + secondName;

            string[] secondInput = Console.ReadLine()
                .Split();
            string name = secondInput[0];
            int litersBeer = int.Parse(secondInput[1]);
            bool drunk = secondInput[2] == "drunk" ? true : false;

            string[] thirdInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string personName = thirdInput[0];
            double balance = double.Parse(thirdInput[1]);
            string bankName = thirdInput[2];

            var firstOutput = new Threeuple<string, string, string>(fullName, address, town);
            var secondOutput = new Threeuple<string, int, bool>(name, litersBeer, drunk);
            var thirdOutput = new Threeuple<string, double, string>(personName, balance, bankName);

            Console.WriteLine(firstOutput);
            Console.WriteLine(secondOutput);
            Console.WriteLine(thirdOutput);
        }
    }
}
