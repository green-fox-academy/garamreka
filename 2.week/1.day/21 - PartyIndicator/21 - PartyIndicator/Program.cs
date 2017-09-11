using System;

namespace _21___PartyIndicator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of girls: ");
            int girls = int.Parse(Console.ReadLine());
            Console.Write("Number of boys: ");
            int boys = int.Parse(Console.ReadLine());

            if (girls == 0)
            {
                Console.Write("Sausage party");
            }
            else if (girls == boys && (girls + boys) >= 20)
            {
                Console.Write("The party is excellent");
            }
            else if ((girls + boys) >= 20 && (girls > boys || boys > girls))
            {
                Console.Write("Quite cool party");
            }
            else if ((girls + boys) < 20)
            {
                Console.Write("Average party...");
            }
           
            Console.ReadLine();
        }
    }
}
