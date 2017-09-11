using System;

namespace _12___Cuboid
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 20;
            double c = 30;

            double surface = 2 * ((a * b) + (b * c) + (c * a));
            double volume = a * b * c;

            Console.WriteLine(surface);
            Console.WriteLine(volume);
            Console.ReadLine();
        }
    }
}
