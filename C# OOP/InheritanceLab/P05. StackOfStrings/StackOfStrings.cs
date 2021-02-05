using System;
using System.Collections.Generic;
using System.Text;

namespace _05._StackOfStrings
{
    class StackOfStrings : Stack<string>
    {
        public bool IsEmpty()
        {
            return this.Count == 0;
        }

        public void AddRange(Stack<string> stack)
        {
            this.Push(stack);
        }
    }
}
