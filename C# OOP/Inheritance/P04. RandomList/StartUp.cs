using P04._RandomList;
using System;

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

            string returned = rndList.Remove();

            while (rndList.Counter > 0)
            {
                Console.WriteLine(returned);
            }
        }
    }
}
