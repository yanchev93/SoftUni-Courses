using System;

namespace _1.SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int highestNum = int.MinValue;
            int middleNum = int.MinValue;
            int lowestNum = int.MinValue;


            if (n1 > n2 && n1 > n3)
            {
                highestNum = n1;
                if (n2 > n3)
                {
                    middleNum = n2;
                    lowestNum = n3;
                }
                else
                {
                    middleNum = n3;
                    lowestNum = n2;
                }
            }
            else if (n2 > n1 && n2 > n3)
            {
                highestNum = n2;
                if (n1 > n3)
                {
                    middleNum = n1;
                    lowestNum = n3;
                }
                else
                {
                    middleNum = n3;
                    lowestNum = n1;
                }
            }
            else if (n3 > n1 && n3 > n2)
            {
                highestNum = n3;
                if (n1 > n2)
                {
                    middleNum = n1;
                    lowestNum = n2;
                }
                else
                {
                    middleNum = n2;
                    lowestNum = n1;
                }
            }         
            Console.WriteLine(highestNum);
            Console.WriteLine(middleNum);
            Console.WriteLine(lowestNum);
        }
    }
}
