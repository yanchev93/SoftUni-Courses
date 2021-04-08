using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._DragonArmy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, SortedDictionary<string, List<int>>> dragons = new Dictionary<string, SortedDictionary<string, List<int>>>();

            int numDragons = int.Parse(Console.ReadLine());
            for (int i = 0; i < numDragons; i++)
            {
                string[] currentDragon = Console.ReadLine().Split();
                string colorDragon = currentDragon[0];
                string nameDragon = currentDragon[1];
                List<int> stats = new List<int>();

                int damage = IsDamageNull(currentDragon);
                int health = IsHealthNull(currentDragon);
                int armor = IsArmorNull(currentDragon);

                if (!dragons.ContainsKey(colorDragon))
                {
                    dragons[colorDragon] = new SortedDictionary<string, List<int>>();
                    dragons[colorDragon][nameDragon] = new List<int>();

                    dragons[colorDragon][nameDragon].Add(damage);
                    dragons[colorDragon][nameDragon].Add(health);
                    dragons[colorDragon][nameDragon].Add(armor);

                    continue;
                }

                if (dragons[colorDragon].ContainsKey(nameDragon))
                {
                    dragons[colorDragon][nameDragon] = new List<int>();

                    dragons[colorDragon][nameDragon].Add(damage);
                    dragons[colorDragon][nameDragon].Add(health);
                    dragons[colorDragon][nameDragon].Add(armor);

                    continue;
                }

                dragons[colorDragon][nameDragon] = new List<int>();

                dragons[colorDragon][nameDragon].Add(damage);
                dragons[colorDragon][nameDragon].Add(health);
                dragons[colorDragon][nameDragon].Add(armor);
            }

            int[] avrg = new int[3];
            int divideBy = 0;

            foreach (var dragon in dragons)
            {
                var colorDragon = dragon.Key;
                var dragonCollection = dragon.Value;
                avrg = new int[3];
                divideBy = 0;
                Console.Write($"{colorDragon}::");
                foreach (var nameAndStats in dragonCollection)
                {
                    var name = nameAndStats.Key;
                    List<int> stats = nameAndStats.Value;
                    divideBy += 1;

                    for (int i = 0; i < stats.Count; i++)
                    {
                        avrg[i] += stats[i];
                    }
                }
                double avrg1 = (double)avrg[0] / divideBy;
                double avrg2 = (double)avrg[1] / divideBy;
                double avrg3 = (double)avrg[2] / divideBy;

                Console.WriteLine($"({avrg1:f2}/{avrg2:f2}/{avrg3:f2})");

                foreach (var nameDragon in dragonCollection)
                {
                    var name = nameDragon.Key;
                    var stats = nameDragon.Value;

                    Console.WriteLine($"-{name} -> damage: {stats[0]}, health: {stats[1]}, armor: {stats[2]}");
                }
            }
        }
        static int IsDamageNull(string[] currentDragon)
        {
            int damage = 0;

            if (currentDragon[2] == "null")
            {
                damage = 45;
            }
            else
            {
                damage = int.Parse(currentDragon[2]);
            }

            return damage;
        }

        static int IsHealthNull(string[] currentDragon)
        {
            int health = 0;

            if (currentDragon[3] == "null")
            {
                health = 250;
            }
            else
            {
                health = int.Parse(currentDragon[3]);
            }

            return health;
        }
        
        static int IsArmorNull(string[] currentDragon)
        {
            int armor = 0;

            if (currentDragon[4] == "null")
            {
                armor = 10;
            }

            else
            {
                armor = int.Parse(currentDragon[4]);
            }

            return armor;
        }
    }
}
