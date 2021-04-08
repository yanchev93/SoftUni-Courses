using System;
using System.Linq;
using System.Collections.Generic;


namespace _2._Common_Elements
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, int> materials = new Dictionary<string, int>();
            Dictionary<string, int> junks = new Dictionary<string, int>();

            materials["shards"] = 0;
            materials["fragments"] = 0;
            materials["motes"] = 0;
            bool isObtained = true;

            while (isObtained)
            {
                string[] givenMaterials = Console.ReadLine()
                                          .ToLower()
                                          .Split()
                                          .ToArray();

                for (int i = 0; i < givenMaterials.Length; i +=2)
                {
                    int currentQuantity = int.Parse(givenMaterials[i]);
                    string currentMaterial = givenMaterials[i + 1];

                    if (currentMaterial == "shards")
                    {
                        materials[currentMaterial] += currentQuantity;
                        if (materials[currentMaterial] >= 250)
                        {
                            Console.WriteLine("Shadowmourne obtained!");
                            materials[currentMaterial] -= 250;
                            isObtained = false;
                            break;
                        }
                    }
                    else if (currentMaterial == "fragments")
                    {
                        materials[currentMaterial] += currentQuantity;
                        if (materials[currentMaterial] >= 250)
                        {
                            Console.WriteLine("Valanyr obtained!");
                            materials[currentMaterial] -= 250;
                            isObtained = false;
                            break;
                        }
                    }
                    else if (currentMaterial == "motes")
                    {
                        materials[currentMaterial] += currentQuantity;
                        if (materials[currentMaterial] >= 250)
                        {
                            Console.WriteLine("Dragonwrath obtained!");
                            materials[currentMaterial] -= 250;
                            isObtained = false;
                            break;
                        }
                    }
                    else
                    {
                        if (!junks.ContainsKey(currentMaterial))
                        {
                            junks[currentMaterial] = 0;
                        }

                        junks[currentMaterial] += currentQuantity;
                    }

                }
            }
            materials = materials
                       .OrderByDescending(x => x.Value)
                       .ThenBy(x => x.Key)
                       .ToDictionary(x => x.Key, x => x.Value);

            junks = junks
                    .OrderBy(x => x.Key)
                    .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in materials)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            foreach (var kvp in junks)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}