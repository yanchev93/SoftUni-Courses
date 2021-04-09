
namespace WarCroft.Entities.Inventory
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using WarCroft.Entities.Items;

    public abstract class Bag : IBag
    {
        private int capacity = 100;
        private int load;
        private readonly List<Item> items;

        protected Bag(int capacity)
        {
            this.items = new List<Item>();

            this.Capacity = capacity;
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            set
            {
                this.capacity = value;
            }
        }

        public int Load
        {

            get
            {
                this.load = this.items.Select(x => x.Weight).Sum();

                return this.load;
            }
        }
        public IReadOnlyCollection<Item> Items
        {
            get
            {
                return this.items;
            }
        }

        public void AddItem(Item item)
        {
            if (this.load + item.Weight > this.capacity)
            {
                throw new InvalidOperationException("Bag is full!");
            }

            this.items.Add(item);
        }

        public Item GetItem(string name)
        {
            if (this.items.Count == 0)
            {
                throw new InvalidOperationException("Bag is empty!");
            }

            var getItem = this.items.FirstOrDefault(x => x.GetType().Name == name);

            if (getItem == null)
            {
                throw new ArgumentException($"No item with name {name} in bag!");
            }

            this.items.Remove(getItem);

            return getItem;
        }
    }
}
