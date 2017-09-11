using System;

namespace _15___MileToKmConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringKm;
            Console.WriteLine("Write distance in km:");
            stringKm = Console.ReadLine();
            int km = Int32.Parse(stringKm);
            double mile = km * 0.621371192;
            Console.WriteLine("It's " + mile + " mile");
            Console.ReadLine();
        }
    }
}
