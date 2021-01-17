namespace GenericCountMethodString
{
    using System;
    using System.Collections.Generic;

    public class Box<T> where T : IComparable
    {
        public List<T> myList { get; set; } = new List<T>();
        
        public void Add(T element)
        {
            this.myList.Add(element);
        }

        public int CountElementsGreatherThan(T compare)
        {
            int count = 0;

            foreach (var element in this.myList)
            {
                if (element.CompareTo(compare) > 0)
                {
                    count += 1;
                }
            }

            return count;
        }
    }
}
