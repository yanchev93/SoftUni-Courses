namespace Bakery.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Bakery.Core.Contracts;
    using Bakery.Models.BakedFoods.Contracts;
    using Bakery.Models.Drinks.Contracts;
    using Bakery.Models.Tables.Contracts;

    public class Controller : IController
    {
        private readonly List<IBakedFood> bakedFoods;
        private readonly List<IDrink> drinks;
        private readonly List<ITable> tables;
        private decimal totalIncome;

        public Controller()
        {
            this.bakedFoods = new List<IBakedFood>();
            this.drinks = new List<IDrink>();
            this.tables = new List<ITable>();
        }

        public string AddFood(string type, string name, decimal price)
        {

            IBakedFood food = null;

            if (type == "Bread")
            {
                food = new Bread(name, price);
            }
            else if (type == "Cake")
            {
                food = new Cake(name, price);
            }

            this.bakedFoods.Add(food);

            return $"Added {name} ({type}) to the menu";
        }

        public string AddDrink(string type, string name, int portion, string brand)
        {
            IDrink drink = null;

            if (type == "Tea")
            {
                drink = new Tea(name, portion, brand);
            }
            else if (type == "Water")
            {
                drink = new Water(name, portion, brand);
            }

            this.drinks.Add(drink);

            return $"Added {name} ({brand}) to the drink menu";
        }

        public string AddTable(string type, int tableNumber, int capacity)
        {
            ITable table = null;

            if (type == "InsideTable")
            {
                table = new InsideTable(tableNumber, capacity);
            }
            else if (type == "OutsideTable")
            {
                table = new OutsideTable(tableNumber, capacity);
            }

            this.tables.Add(table);

            return $"Added table number {tableNumber} in the bakery";
        }

        public string ReserveTable(int numberOfPeople)
        {
            var isTableReserved = this.tables.FirstOrDefault(x => x.IsReserved == false && x.NumberOfPeople <= numberOfPeople);

            if (isTableReserved == null)
            {
                return $"No available table for {numberOfPeople} people";
            }

            isTableReserved.Reserve(numberOfPeople);

            return $"Table {isTableReserved.TableNumber} has been reserved for {numberOfPeople} people";
        }

        public string OrderFood(int tableNumber, string foodName)
        {
            var table = this.tables.FirstOrDefault(x => x.TableNumber == tableNumber);
            var food = this.bakedFoods.FirstOrDefault(x => x.Name == foodName);

            if (table == null)
            {
                return $"Could not find table {tableNumber}";
            }

            if (food == null)
            {
                return $"No {foodName} in the menu";
            }

            table.OrderFood(food);

            return $"Table {tableNumber} ordered {foodName}";
        }

        public string OrderDrink(int tableNumber, string drinkName, string drinkBrand)
        {
            var table = this.tables.FirstOrDefault(x => x.TableNumber == tableNumber);
            var drink = this.drinks.FirstOrDefault(x => x.Name == drinkName && x.Brand == drinkBrand);

            if (table == null)
            {
                return $"Could not find table {tableNumber}";
            }

            if (drink == null)
            {
                return $"There is no {drinkName} {drinkBrand} available";
            }

            table.OrderDrink(drink);

            return $"Table {tableNumber} ordered {drinkName} {drinkBrand}";
        }

        public string LeaveTable(int tableNumber)
        {
            var table = this.tables.FirstOrDefault(x => x.TableNumber == tableNumber);

            var tableBill = table.GetBill();
            table.Clear();

            this.totalIncome += tableBill;

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Table: {tableNumber}");
            sb.AppendLine($"Bill: {tableBill:f2}");

            return sb.ToString().TrimEnd();
        }

        public string GetFreeTablesInfo()
        {
            var freeTables = this.tables.FindAll(x => x.IsReserved == false);

            StringBuilder sb = new StringBuilder();

            foreach (var table in freeTables)
            {
                sb.AppendLine(table.GetFreeTableInfo());
            }

            return sb.ToString().TrimEnd();
        }

        public string GetTotalIncome()
        {
            decimal income = 0;

            income += this.totalIncome;

            return $"Total income: {income:f2}lv";
        }

    }
}
