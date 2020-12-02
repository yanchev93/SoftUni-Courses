using System;

namespace ClassAndObjects___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            ListRandomizer rand = new ListRandomizer();
            rand.Words = Console.ReadLine().Split();

            rand.Randomise();
            rand.PrintWords();
        }
    }
    public class ListRandomizer
    {
        public string[] Words;

        public void Randomise()
        {
            Random rand = new Random();

            for (int i = 0; i < this.Words.Length; i++)
            {
                int randomPosition = rand.Next(0, this.Words.Length);

                string temp = this.Words[i];
                this.Words[i] = this.Words[randomPosition];
                this.Words[randomPosition] = temp;
            }
        }

        public void PrintWords()
        {
            Console.WriteLine(string.Join(Environment.NewLine, Words));
        }
    }
}
