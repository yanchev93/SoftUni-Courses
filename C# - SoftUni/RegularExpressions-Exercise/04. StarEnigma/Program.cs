using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _04._StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([^-@!:>]*?)@([^-@!:>]*?)(?<name>[A-z]+)([^-@!:>]*?):([^-@!:>]*?)(?<population>\d+)([^-@!:>]*?)!([^-@!:>]*?)(?<attack>[A|D])([^-@!:>]*?)!([^-@!:>]*?)->([^-@!:>]*?)(?<soldier>\d+)([^-@!:>]*?)";
            int messages = int.Parse(Console.ReadLine());

            List<string> AttackedPlanets = new List<string>();
            List<string> DestroyedPlanets = new List<string>();

            for (int i = 0; i < messages; i++)
            {
                string encryptedMSG = Console.ReadLine();
                int countStar = 0;

                for (int j = 0; j < encryptedMSG.Length; j++)
                {
                    bool star = encryptedMSG[j] == 's' || encryptedMSG[j] == 't' || encryptedMSG[j] == 'a'
                        || encryptedMSG[j] == 'r' || encryptedMSG[j] == 'S' || encryptedMSG[j] == 'T' || encryptedMSG[j] == 'A'
                        || encryptedMSG[j] == 'R';

                    if (star)
                    {
                        countStar += 1;
                    }
                }
                
                StringBuilder decryptedMSG = new StringBuilder();

                for (int k = 0; k < encryptedMSG.Length; k++)
                {
                    decryptedMSG.Append((char)(encryptedMSG[k] - countStar));
                }

                string input = decryptedMSG.ToString();
                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    string population = match.Groups["population"].Value;
                    string attackType = match.Groups["attack"].Value;
                    string soldiers = match.Groups["soldier"].Value;

                    if (attackType == "A")
                    {
                        AttackedPlanets.Add(name);
                    }

                    else
                    {
                        DestroyedPlanets.Add(name);
                    }
                }
            }

            AttackedPlanets.Sort();
            DestroyedPlanets.Sort();

            if (AttackedPlanets.Count == 0)
            {
                Console.WriteLine("Attacked planets: 0");
            }

            else
            {
                Console.WriteLine($"Attacked planets: {AttackedPlanets.Count()}" +
                    $"{Environment.NewLine}-> {string.Join($"{Environment.NewLine}-> ", AttackedPlanets)}");

            }

            if (DestroyedPlanets.Count == 0)
            {
                Console.WriteLine("Destroyed planets: 0");
            }

            else
            {
                Console.WriteLine($"Destroyed planets: {DestroyedPlanets.Count()}" +
                    $"{Environment.NewLine}-> {string.Join($"{Environment.NewLine}-> ", DestroyedPlanets)}");

            }
        }
    }
}
