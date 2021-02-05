using System;
using System.Collections.Generic;

namespace P04._RandomList
{
    public class RandomList : List<string>
    {
        private Random rnd;

        public RandomList()
        {
            this.rnd = new Random();
        }

        public string Remove()
        {
            int removeIndex = this.rnd.Next(0, this.Count);

            string output = this[removeIndex];

            this.RemoveAt(removeIndex);

            return output;
        }
    }
}
