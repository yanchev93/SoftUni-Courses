using System;

namespace GenericScale
{
    public class EqualityScale<T>
            where T : IComparable
    {
        public EqualityScale(T left, T right)
        {
            this.Left = left;
            this.Right = right;
        }

        public T Left { get; private set; }
        public T Right { get; private set; }

        public bool AreEqual()
        {
            bool areEqual = this.Left.Equals(this.Right);

            return areEqual;
        }

    }
}
