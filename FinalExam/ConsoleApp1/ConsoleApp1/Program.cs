using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var OldList = new List<string>()
            {
                "abc",
                "ijk",
                "xyz"
            };

            foreach (var item in TransformList(OldList))
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        private static List<string> TransformList(List<string> stringList)
        {
            var resultArray = new string[stringList.Count];
            var newList = new List<string>();

            for (int i = 0; i < stringList.Count; i++)
            {
                for (int j = 0; j < stringList.Count; j++)
                {
                    resultArray[i] += stringList[j][i];
                }

                newList.Add(resultArray[i]);
            }

            return newList;
        }
    }
}
