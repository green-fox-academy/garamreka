using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApplication
{
    class Garden
    {
        List<Plant> plantList;

        public Garden ()
        {
            plantList = new List<Plant>();
            plantList.Add(new Flower("yellow"));
            plantList.Add(new Flower("blue"));
            plantList.Add(new Tree("purple"));
            plantList.Add(new Tree("orange"));
        }

        public void PrintStatus ()
        {
            foreach (Plant plant in plantList)
            {
                plant.GetStatus();
            }
            Console.WriteLine();
        }

        public void Watering (double totalWater)
        {
            Console.WriteLine("Watering with {0}", totalWater);

            double numberOfThirstyPlant = 0;
            foreach (Plant plant in plantList)
            {
                if (plant.IsThirsty())
                {
                    numberOfThirstyPlant++;
                }
            }
            foreach (Plant plant in plantList)
            {
                if (plant.IsThirsty())
                {
                    plant.AbsorbWater(totalWater / numberOfThirstyPlant);
                }
            }
            PrintStatus();
        }
    }
}
