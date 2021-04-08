namespace CustomStack_Class
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class CustomStack
    {
        const int IntialCapacity = 4;
        private int[] items;
        int count;

        public CustomStack()
        {
            this.items = new int[IntialCapacity];
            this.count = 0;
        }

        public int Count
        {
            get { return this.count; }
        }

        public void Push(int element)
        {
            this.items[this.Count] = element;
            this.count += 1;

            Resize();
        }

        public int Pop()
        {
            ValidateIndex();

            var element = this.items[this.Count - 1];
            this.count -= 1;

            return element;
        }

        public int Peek()
        {
            ValidateIndex();

            var element = this.items[this.Count - 1];

            return element;
        }

        public void ForEach(Action<object> action)
        {
            for (int i = this.Count - 1; i >= 0; i--)
            {
                action(this.items[i]);
            }
        }

        private void Resize()
        {
            if (this.items.Length > this.count)
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

        private void ValidateIndex()
        {
            if (this.items.Length == 0)
            {
                throw new InvalidOperationException("CustomStack is empty");
            }
        }

    }
}
