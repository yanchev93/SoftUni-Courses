using P04._RandomList;
using System;
using System.Collections.Generic;

namespace CustomRandomList
{
    public class StartUp
    {
        public static void Main()
        {
            RandomList rndList = new RandomList();

            for (int i = 1; i < 10; i++)
            {
                rndList.Add($"{i} Add");
            }

            List<string> mylist = new List<string>();
            


            while (rndList.Count > 0)
            {
                string returned = rndList.Remove();

                Console.WriteLine(returned);
            }
        }
    }
}
