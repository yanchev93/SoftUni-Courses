using System;

namespace _01._AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(FakeMessage.PrintFakeMessage());
            }
        }

        public class FakeMessage
        {
            public static string[] Phrases = { "Excellent product.", "Such a great product.",
                "I always use that product.", "Best product of its category.",
                "Exceptional product.", "I can’t live without this product." };

            public static string[] Events = { "Now I feel good.", "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.", "I feel great!" };

            public static string[] Authors = { "Diana", "Petya", "Stella",
                "Elena", "Katya", "Iva", "Annie", "Eva" };

            public static string[] Cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            public static string PrintFakeMessage()
            {
                Random rand = new Random();
                string thisPhrase = Phrases[rand.Next(0, Phrases.Length)];
                string thisEvent = Events[rand.Next(0, Events.Length)];
                string thisAuthor = Authors[rand.Next(0, Authors.Length)];
                string thisCity = Cities[rand.Next(0, Cities.Length)];

                return $"{thisPhrase} {thisEvent} {thisAuthor} - {thisCity}";
            }
        }

    }
}
