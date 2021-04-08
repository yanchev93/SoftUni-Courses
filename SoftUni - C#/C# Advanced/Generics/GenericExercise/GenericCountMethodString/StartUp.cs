namespace GenericCountMethodString
{
    using System;

    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Box<string> box = new Box<string>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();

                box.Add(input);
            }

            var compare = Console.ReadLine();

            var count = box.CountElementsGreatherThan(compare);

            Console.WriteLine(count);
        }
    }
}
