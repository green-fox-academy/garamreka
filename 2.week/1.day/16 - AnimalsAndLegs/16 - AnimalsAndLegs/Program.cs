using System;

namespace _16___AnimalsAndLegs
{
    class Program
    {
        static void Main(string[] args)
        {
            string chicken;
            Console.WriteLine("How many chickens do you have?");
            chicken = Console.ReadLine();
            int intChicken = Int32.Parse(chicken);
            string pig;
            Console.WriteLine("How many pigs do you have?");
            pig = Console.ReadLine();
            int intPig = Int32.Parse(pig);
            int legs = (intChicken * 2) + (intPig * 4);
            Console.WriteLine("Total number of legs of your animals: " + legs);
            Console.ReadLine();
        }
    }
}
