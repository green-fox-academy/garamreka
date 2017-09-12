using System;

namespace PrintAll
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] af = { 4, 5, 6, 7 };
            for (int i = 0; i < af.Length; i++)
            {
                Console.Write(af[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
