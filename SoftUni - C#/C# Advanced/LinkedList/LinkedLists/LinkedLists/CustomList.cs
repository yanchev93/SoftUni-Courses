namespace LinkedLists
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class CustomList
    {
        // CustomList Functions

        // 1
        // void Add(int element) 
        // -> Adds the given element to the end of the list

        // 2
        // int RemoveAt(int index) 
        // -> Removes the element at the given index

        // 3
        // bool Contains(int element) 
        // -> Checks if the list contains the given element returns(True or False)

        // 4
        // void Swap(int firstIndex, int secondIndex) 
        // -> Swaps the elements at the given indexes

        private const int InitialCapacity = 2;

        private int[] items;
        private int count;
        private int indexer;

        // We create the array with starting capacity
        public CustomList()
        {
            this.items = new int[InitialCapacity];
            this.Count = 0;
        }
        public int Count { get; private set; }

        // NB! -> Access the items in the collection without exposing the internal array
        public int this[int index]
        {
            get
            {
                ValidateIndex(index);
                return items[index];
            }
            set
            {
                ValidateIndex(index);
                this.items[index] = value;
            }
        }

        public void Add(int item)
        {
            // Check if the count is same as the length of the array.
            // If they are equal we have to resize the array.
            Resize();
            // Add the item
            this.items[this.Count] = item;
            this.Count += 1;
        }

        public void Insert(int index, int item)
        {
            ValidateIndex(index);
            this.Count += 1;
            Resize();

            ShiftToRight(index);

            this.items[index] = item;
        }
        public int RemoveAt(int index)
        {
            ValidateIndex(index);
            var element = this.items[index];

            ShiftToLeft(index);
            this.Count -= 1;
            Shrink();

            return element;
        }

        public bool Contains(int element)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.items[i] == element)
                {
                    return true;
                }
            }

            return false;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            ValidateIndex(firstIndex);
            ValidateIndex(secondIndex);

            int swapFirst = this.items[firstIndex];
            int swapSecond = this.items[secondIndex];
            this.items[firstIndex] = swapSecond;
            this.items[secondIndex] = swapFirst;
        }

        // This method will be used to increase the internal collection's length twice
        private void Resize()
        {
            if (this.items.Length > this.Count)
            {
                return;
            }

            int[] tempArr = new int[this.items.Length * 2];

            for (int i = 0; i < this.items.Length; i++)
            {
                tempArr[i] = this.items[i];
            }

            this.items = tempArr;
        }

        // This method will help us to decrease the internal collection's length twice 
        private void Shrink()
        {
            if (this.Count * 4 >= this.items.Length)
            {
                return;
            }

            int[] tempArr = new int[this.items.Length / 2];
            for (int i = 0; i < this.Count; i++)
            {
                tempArr[i] = this.items[i];
            }

            this.items = tempArr;
        }

        // This method will help us to rearrange the internal collection's elements after removing one
        private void ShiftToLeft(int index)
        {
            for (int i = index; i < this.Count - 1; i++)
            {
                this.items[i] = this.items[i + 1];
            }

            this.items[this.Count - 1] = default;
        }

        private void ShiftToRight(int index)
        {
            for (int i = this.Count - 1; i > index; i--)
            {
                this.items[i] = this.items[i - 1];
            }
        }

        private void ValidateIndex(int index)
        {
            if (index < 0 || this.Count <= index)
            {
                throw new IndexOutOfRangeException();
            }
        }








    }
}
