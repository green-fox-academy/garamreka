using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApplication
{
    class Tree : Plant
    {
        public Tree(string color) : base(color)
        {
            this.color = color;
            this.absorb = 0.40;
            this.plantType = "Tree";
            this.needsWaterLevel = 10;
        }
    }
}
