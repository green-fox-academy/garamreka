﻿using System;

namespace _24___PrintEven
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 0; i <= 500; i++)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
