using System;
using System.Collections.Generic;

namespace _06._ParkingLot
{
    class StartUp
    {
        static void Main(string[] args)
        {
            HashSet<string> parkingLot = new HashSet<string>();

            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] currentInput = input.Split(", ",
                    StringSplitOptions.RemoveEmptyEntries);
                string direction = currentInput[0];
                string carNumber = currentInput[1];

                if (direction == "OUT" && parkingLot.Contains(carNumber))
                {
                    parkingLot.Remove(carNumber);
                }

                else if (direction == "IN")
                {
                    parkingLot.Add(carNumber);
                }

                input = Console.ReadLine();
            }

            if (parkingLot.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, parkingLot));
            }

            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
