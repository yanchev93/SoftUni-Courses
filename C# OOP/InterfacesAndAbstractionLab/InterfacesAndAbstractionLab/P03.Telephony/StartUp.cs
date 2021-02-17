namespace P03.Telephony
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string[] numbers = Console.ReadLine().Split();
            string[] sites = Console.ReadLine().Split();

            Queue<string> queNumbers = new Queue<string>(numbers);
            Queue<string> queSites = new Queue<string>(sites);

            while (queNumbers.Count > 0)
            {
                string number = queNumbers.Dequeue();

                if (number.Length == 7)
                {
                    IStationaryPhone stationaryPhone = new StationaryPhone();

                    Console.WriteLine(stationaryPhone.Dialing(number));
                }
                else if (number.Length == 10)
                {
                    ISmartphone smartphone = new Smartphone();

                    Console.WriteLine(smartphone.Calling(number));
                }

            }

            while (queSites.Count > 0)
            {
                string webSite = queSites.Dequeue();

                ISmartphone smartphone = new Smartphone();

                Console.WriteLine(smartphone.Browse(webSite));
            }
        }
    }
}
