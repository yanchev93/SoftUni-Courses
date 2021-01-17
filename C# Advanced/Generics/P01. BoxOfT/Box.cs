using System.Collections.Generic;

namespace BoxOfT
{
    class Box<T>
    {
        public Box()
        {
            this.MyList = new List<T>();
            this.Count = 0;
        }

        public List<T> MyList { get; private set; }

        public int Count { get; private set; }

        public void Add(T element)
        {
            this.MyList.Add(element);
            this.Count += 1;
        }

        public T Remove()
        {
            var rem = this.MyList[this.Count - 1];
            this.MyList.RemoveAt(this.Count - 1);
            this.Count -= 1;
            return rem;
        }

    }
}
