using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] currentCommand = command.Split();
                int seriaNumber = int.Parse(currentCommand[0]);
                string itemName = currentCommand[1];
                int itemQuantity = int.Parse(currentCommand[2]);
                double itemPrice = double.Parse(currentCommand[3]);

                double pricePerBox = itemQuantity * itemPrice;

                Box currentBox = new Box(seriaNumber, itemQuantity, pricePerBox);
                currentBox.Item = new Item();
                currentBox.Item.Name = itemName;
                currentBox.Item.Price = itemPrice;

                boxes.Add(currentBox);

                command = Console.ReadLine();
            }

            foreach (var item in boxes.OrderByDescending(x=>x.PricePerBox))
            {
                Console.WriteLine(item.SerialNumber);
                Console.WriteLine(item.ToString());
            }
        }

        public class Item
        {
            public string Name { get; set; }
            public double Price { get; set; }
        }

        public class Box
        {
            public int SerialNumber { get; set; }

            public Box()
            {
                Item = new Item();
            }

            public Item Item { get; set; }

            public int ItemQuantity { get; set; }

            public double PricePerBox { get; set; }

            public Box(int serialNumber, int itemQuantity, double pricePerBox)
            {
                this.SerialNumber = serialNumber;
                this.ItemQuantity = itemQuantity;
                this.PricePerBox = pricePerBox;
            }

            public override string ToString()
            {
                return $"-- {Item.Name} - ${Item.Price:f2}: {ItemQuantity}" +
                    $"{Environment.NewLine}-- ${PricePerBox:f2}";
                
            }
        }
    }
}
