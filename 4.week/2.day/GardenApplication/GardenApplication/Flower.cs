using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApplication
{
    class Flower : Plant
    {
        public Flower(string color)
        {
            this.color = color;
            this.absorb = 0.75;
            this.plantType = "Flower";
            this.needsWaterLevel = 5;
        }
    }
}
