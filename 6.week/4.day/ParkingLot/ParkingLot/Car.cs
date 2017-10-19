using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    class Car
    {
        public string TypeOfCar { get; set; }
        public string ColorOfCar { get; set; }

        public Car(CarType type, CarColor color)
        {
            this.TypeOfCar = type.ToString();
            this.ColorOfCar = color.ToString();
        }

        public enum CarType
        {
            MazdaCx5,
            Fiat500,
            VolvoXc90,
            HorseTrailer
        }

        public enum CarColor
        {
            CristalSoulRed,
            Champagne,
            ArcticWhite,
            DeepBlue,
            BrightSilver,
            AppleGreen,
            OnyxBlack
        }

    }
}
