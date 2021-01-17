namespace GenericSwapMethodStrings
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Box<T>
    {
        public List<T> myList { get; private set; } = new List<T>();

        public void Add(T element)
        {
            this.myList.Add(element);
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            var temp = this.myList[firstIndex];

            this.myList[firstIndex] = this.myList[secondIndex];
            this.myList[secondIndex] = temp;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var value in this.myList)
            {
                sb.AppendLine($"{value.GetType()}: {value}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
