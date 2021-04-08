namespace LinkedLists
{
    using System;
    using System.Diagnostics;

    public class StartUp
    {
        static void Main(string[] args)
        {
            var myList = new CustomList();

            for (int i = 0; i < 10; i++)
            {
                myList.Add(i);
            }

            // Debug.Assert(myList[2] == 2);
            // Debug.Assert(myList[3] == 3);
            // 
            // myList.RemoveAt(2);

            Debug.Assert(myList[2] == 5);

            myList.Insert(5, 222);

            var isContained = myList.Contains(222);
            var isNotContained = myList.Contains(333);

            myList.Swap(5, 3);
        }
    }
}
