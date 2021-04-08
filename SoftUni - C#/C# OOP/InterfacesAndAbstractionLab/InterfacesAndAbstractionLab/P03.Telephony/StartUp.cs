using System;
using P03.Telephony;

class Program
{
    static void Main(string[] args)
    {
        string[] numbers = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries);
        string[] urls = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries);

        Smartphone smartphone = new Smartphone();
        StationeryPhone stationeryPhone = new StationeryPhone();

        foreach (var number in numbers)
        {
            if (number.Length == 10)
            {
                Console.WriteLine(smartphone.Call(number));
            }
            else if (number.Length == 7)
            {
                Console.WriteLine(stationeryPhone.Call(number));
            }
        }

        foreach (var url in urls)
        {
            Console.WriteLine(smartphone.Browse(url));
        }
    }
}