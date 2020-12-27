using System;
using System.Collections.Generic;

namespace _04._CitiesByContinentAndCountry
{
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var earth = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ',
                    StringSplitOptions.RemoveEmptyEntries);
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!earth.ContainsKey(continent))
                {
                    earth[continent] = new Dictionary<string, List<string>>();
                }

                var currentContinent = earth[continent];
                if (!currentContinent.ContainsKey(country))
                {
                    currentContinent[country] = new List<string>();
                }

                currentContinent[country].Add(city);
            }

            foreach (var (continent, country) in earth)
            {
                Console.WriteLine($"{continent}:");

                foreach (var city in country)
                {
                    Console.WriteLine($"{city.Key} -> {string.Join(", ", city.Value)}");
                }
            }
        }
    }
}
