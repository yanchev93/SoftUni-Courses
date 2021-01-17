namespace GenericCountMethodString
{
    using System;

    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Box<double> box = new Box<double>();
            for (int i = 0; i < n; i++)
            {
                var input = double.Parse(Console.ReadLine());

                box.Add(input);
            }

            var compare = double.Parse(Console.ReadLine());

            var count = box.CountElementsGreatherThan(compare);

            Console.WriteLine(count);
        }
    }
}
