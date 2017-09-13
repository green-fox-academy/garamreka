using System;
using System.Collections.Generic;
using System.Linq;

namespace _11___IsInList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 2, 4, 6, 8, 10, 12, 14, 16 };

            // Check if list contains all of the following elements: 4,8,12,16
            // Print "true" if it contains all, otherwise print "false"
            // Can you do both the different approaches you tried in the previous one?


            //First solution
            int n1 = 4;
            int n2 = 8;
            int n3 = 12;
            int n4 = 16;
            int contains = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == n1 || list[i] == n2 || list[i] == n3 || list[i] == n4)
                {
                    contains++;
                }  
            }
            if (contains == 4)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            Console.ReadLine();
        }
    }
}
