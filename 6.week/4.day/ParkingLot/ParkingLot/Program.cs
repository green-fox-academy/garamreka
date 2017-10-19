using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            Print(CountEachType(CreateCarList()));
            Console.WriteLine();
            Print(CountEachColor(CreateCarList()));
            Console.WriteLine();
            Console.WriteLine(FindMostFrequent(CreateCarList()));

            Console.ReadLine();
        }

        static List<Car> CreateCarList()
        {
            var carList = new List<Car>();
            var random = new Random();
            int listSize = 256;

            for (int i = 0; i < listSize; i++)
            {
                carList.Add(new Car((Car.CarType)random.Next(0, 4), (Car.CarColor)random.Next(0, 6)));
            }
            return carList;
        }

        static Dictionary<string, int> CountEachType(List<Car> input)
        {
            var typeDictionary = (from car in input
                                  group car by car.TypeOfCar into groups
                                  select new { key = groups.Key, value = groups.Count() })
                                  .ToDictionary(g => g.key, g => g.value);

            return typeDictionary;
        }

        static Dictionary<string, int> CountEachColor(List<Car> input)
        {
            var colorDictionary = input.GroupBy(car => car.ColorOfCar).ToDictionary(key => key.Key, value => value.Count());
            return colorDictionary;
        }

        static void Print(Dictionary<string, int> input)
        {
            foreach (var car in input)
            {
                Console.WriteLine(car);
            }
        }

        static KeyValuePair<string, int> FindMostFrequent(List<Car> input)
        {
            var groupByTypeAndColor = input.GroupBy(car => car.ColorOfCar + " " + car.TypeOfCar).ToDictionary(key => key.Key, value => value.Count());
            var mostFrequent = groupByTypeAndColor.FirstOrDefault(x => x.Value == groupByTypeAndColor.Values.Max());

            return mostFrequent;
        }
    }
}
