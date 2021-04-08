using System;
using System.Linq;
using System.Text;

namespace _03._TreasureFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] key = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int lengthKey = key.Length;

            string command = Console.ReadLine();
            while (command != "find")
            {
                StringBuilder decriptedString = new StringBuilder();


                if (key.Length < command.Length)
                {
                    decriptedString = FindTreasure(command, key);
                }

                else
                {
                    decriptedString = FindTresureReverse(command, key);
                }

                Console.WriteLine(PrintTreasure(decriptedString));

                command = Console.ReadLine();
            }
        }
        static StringBuilder FindTreasure(string command, int[] key)
        {
            StringBuilder decriptedString = new StringBuilder();

            for (int i = 0; i < command.Length; i++)
            {
                for (int j = 0; j < key.Length; j++)
                {
                    if (command.Length == decriptedString.Length)
                    {
                        break;
                    }

                    int asciiNum = command[i] - key[j];
                    char letter = (char)asciiNum;

                    i++;

                    decriptedString.Append(letter);
                }

                i--;
            }

            return decriptedString;
        }

        static StringBuilder FindTresureReverse(string command, int[] key)
        {
            StringBuilder decriptedString = new StringBuilder();

            for (int i = command.Length - 1; i >= 0; i--)
            {
                for (int j = command.Length - 1; j >= 0; j--)
                {
                    if (command.Length == decriptedString.Length)
                    {
                        break;
                    }

                    int asciiNum = command[i] - key[j];
                    char letter = (char)asciiNum;

                    i--;

                    decriptedString.Append(letter);
                }

                i++;
            }

            return decriptedString;
        }

        static string PrintTreasure(StringBuilder decriptedString)
        {
            StringBuilder treasure = new StringBuilder();
            StringBuilder coordinates = new StringBuilder();

            string decStr = decriptedString.ToString();

            int treasureStartIndex = decStr.IndexOf('&') + 1;
            int tresureLastIndex = decStr.IndexOf('&', treasureStartIndex);
            int length = tresureLastIndex - treasureStartIndex;

            treasure.Append(decStr.Substring(treasureStartIndex, length));

            int coordinatesStartIndex = decStr.IndexOf('<') + 1;
            int coordinatesLastIndex = decStr.IndexOf('>');
            length = coordinatesLastIndex - coordinatesStartIndex;

            coordinates.Append(decStr.Substring(coordinatesStartIndex, length));

            return $"Found {treasure} at {coordinates}";
        }
    }
}
