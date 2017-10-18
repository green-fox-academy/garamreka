using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a Fox class with 3 properties(name, type, color) 
            //Fill a list with at least 5 foxes, it's up to you how you name/create them! 
            //Write a LINQ Expression to find the foxes with green color! 
            //Write a LINQ Expression to find the foxes with green color and pallida type!

            List<Fox> pack = new List<Fox>();
            pack.Add(new Fox("Csele", "ferrilata", "green"));
            pack.Add(new Fox("Iny", "zerda", "palebrown"));
            pack.Add(new Fox("Kag", "lagopus", "white"));
            pack.Add(new Fox("Karak", "vulpes", "red"));
            pack.Add(new Fox("Vuk", "pallida", "green"));


            foreach (var fox in FindGreenFox(pack))
            {
                Console.WriteLine($"{fox.Name} is a {fox.Color} fox");
            }
            Console.WriteLine();

            foreach (var fox in FindPallidaAndGreen(pack))
            {
                Console.WriteLine($"{fox.Name} is {fox.Color} and has the type of {fox.Type}");
            }
            Console.ReadLine();
        }

        static List<Fox> FindGreenFox(List<Fox> pack)
        {
            var greenFox =
                (from fox in pack
                where fox.Color == "green"
                select fox).ToList();

            return greenFox;
        }

        static List<Fox> FindPallidaAndGreen(List<Fox> pack)
        {
            var pallidaAndGreen = pack.Where(fox => fox.Color == "green" && fox.Type == "pallida").ToList();
            return pallidaAndGreen;
        }
    }
}
