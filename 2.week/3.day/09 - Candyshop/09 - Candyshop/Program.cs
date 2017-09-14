using System;
using System.Collections.Generic;

namespace _09___Candyshop
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<object>();
            list.Add("Cupcake");
            list.Add(2);
            list.Add("Brownie");
            list.Add(false);

            // Accidentally we added "2" and "false" to the list. 
            // Your task is to change from "2" to "Croissant" and change from "false" to "Ice cream"
            // No, don't just remove the lines

            //list[list.FindIndex(ind => ind.Equals(2))] = "Croissant";
            //list[list.FindIndex(ind => ind.Equals(false))] = "Ice Cream";

            list[list.IndexOf(2)] = "Croissant".ToString();
            list[list.IndexOf(false)] = "Ice cream".ToString();

            foreach (var candy in list)
            {
                Console.WriteLine(candy);
            }

            Console.ReadLine();
        }
    }
}
