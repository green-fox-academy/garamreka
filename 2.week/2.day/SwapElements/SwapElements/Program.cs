using System;

namespace SwapElements
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `abc`
            //   with the following content: `["first", "second", "third"]`
            // - Swap the first and the third element of `abc`
            string[] abc = { "first", "second", "third" };

            Swap(abc);
            for (int i = 0; i < abc.Length; i++)
            {
                Console.WriteLine(abc[i]);
            }
            Console.ReadLine();
        }

        public static void Swap(string[] array)
        {
            var tmp = array[0];
            array[0] = array[array.Length-1];
            array[array.Length - 1] = tmp;
        }
    }
}
