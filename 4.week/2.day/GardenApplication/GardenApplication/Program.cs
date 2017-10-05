using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Garden garden = new Garden();
            garden.PrintStatus();
            garden.Watering(40);
            garden.Watering(70);

            Console.ReadLine();
        }
    }
}
