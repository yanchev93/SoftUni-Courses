namespace CustomStack_Class
{
    using System;

    class StartUp
    {
        static void Main()
        {
            var myStack = new CustomStack();

            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);
            myStack.Push(6);

            var ele1Peek = myStack.Peek();
            var ele1 = myStack.Pop();

            var ele2Peek = myStack.Peek();
            var ele2 = myStack.Pop();

            var ele3Peek = myStack.Peek();
            var ele3 = myStack.Pop();

            myStack.ForEach(x => Console.WriteLine(x));

        }
    }
}

