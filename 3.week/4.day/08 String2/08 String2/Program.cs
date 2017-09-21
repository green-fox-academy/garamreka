using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_String2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a string, compute recursively a new string where all the 'x' chars have been removed.

            string myString = "xoxoxo";
            int stringLength = myString.Length;

            Console.WriteLine(Replace(myString, stringLength));
            Console.ReadLine();
        }
        public static string Replace(string myString, int length)
        {
            if (length == 0)
            {
                return "";
            }
            else
            {
                if (myString.Substring(length - 1, 1) == "x")
                {
                    return Replace(myString, length - 1) + "";
                }
                else
                {
                    return Replace(myString, length - 1) + myString.Substring(length - 1, 1);
                }
            }
        }
    }
}
