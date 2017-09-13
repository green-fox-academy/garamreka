using System;
using System.Collections.Generic;

namespace _06___SolarSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var planetList = new List<string> { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus",
            "Neptune" };


            // Saturn is missing from the planetList
            // Insert it into the correct position

            planetList.Insert(5, "Saturn");

            foreach (var planet in planetList)
            {
                Console.Write(planet + " ");
            }
            
            Console.ReadLine();
        }
    }
}
