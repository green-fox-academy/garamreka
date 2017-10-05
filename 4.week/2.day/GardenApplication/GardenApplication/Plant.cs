using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApplication
{
    class Plant
    {
        protected string color;
        protected double absorb;
        protected string plantType;
        protected double currentWaterLevel = 0;
        protected double needsWaterLevel;

        public bool IsThirsty ()
        {
            return needsWaterLevel > currentWaterLevel;
        }
        public void GetStatus()
        {
            string status = "doesnt need water";
            if (IsThirsty())
            {
                status = "needs water";
            }
            Console.WriteLine("The {0} {1} {2}", color, plantType, status);
        }
        public void AbsorbWater (double waterUnit)
        {
            currentWaterLevel += absorb * waterUnit;
        }
    }
}
