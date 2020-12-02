using System;

namespace _010.Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            byte y = byte.Parse(Console.ReadLine());

            int countPokes = 0;
            int Power = n;
            /*
            Your task is to start subtracting M from N until N becomes less than M, i.e. the Poke Mon does
            not have enough power to reach the next target.
            Every time you subtract M from N that means you’ve reached a target and poked it
            successfully. COUNT how many targets you’ve poked – you’ll need that count.
            The Poke Mon becomes gradually more exhausted. IF N becomes equal to EXACTLY 50 % of its
            original value, you must divide N by Y, if it is POSSIBLE. This DIVISION is between integers.
            If a division is not possible, you should NOT do it. Instead, you should continue subtracting.
            After dividing, you should continue subtracting from N, until it becomes less than M.

            */
            while (Power >= m)
            {                
                if (Power == n / 2 && y > 0)
                {
                    Power /= y;
                    if (Power < m)
                    {
                        break;
                    }
                }

                countPokes += 1;
                Power -= m;
            }
            Console.WriteLine(Power);
            Console.WriteLine(countPokes);
        }
    }
}
