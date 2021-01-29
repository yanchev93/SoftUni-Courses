using System;
using System.Collections.Generic;

namespace P04._RandomList
{
    public class RandomList
    {
        public RandomList()
        {
            this.MyList = new List<string>();
        }

        public List<string> MyList { get; private set; }
        public int Counter
        {
            get
            {
                return this.MyList.Count;
            }
        }

        public void Add(string input)
        {
            MyList.Add(input);
        }

        public string Remove()
        {
            Random rnd = new Random();
            int removeIndex = rnd.Next(0, Counter - 1);

            string output = this.MyList[removeIndex];

            this.MyList.RemoveAt(removeIndex);

            return output;
        }
    }
}
