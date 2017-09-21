using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_String3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a string, compute recursively a new string where all the
            // adjacent chars are now separated by a "*".

            string myString = "xoxo";
            int stringLength = myString.Length;

            Console.WriteLine(Star(myString, stringLength));
            Console.ReadLine();
        }
        public static string Star(string myString, int length)
        {
            if (length == 0)
            {
                return "*";
            }
            else
            {
                return Star(myString, length - 1) + myString.Substring(length - 1, 1) + "*";
            }
        }
    }
}
