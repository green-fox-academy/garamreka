using System;

namespace _11___VariableMutation
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            // make it bigger by 10
            a += 10;
            Console.WriteLine("a: " + a);

            int b = 100;
            // make it smaller by 7
            b -= 7;
            Console.WriteLine("b: " + b);

            int c = 44;
            // please double c's value
            c *= 2;
            Console.WriteLine("c: " + c);

            int d = 125;
            // please divide by 5 d's value
            d /= 5;
            Console.WriteLine("d: " + d);

            int e = 8;
            // please cube of e's value
            e *= e * e;
            Console.WriteLine("e: " + e);

            int f1 = 123;
            int f2 = 345;
            // tell if f1 is bigger than f2 (print as a boolean)
            Console.WriteLine("f: " + (f1 > f2));

            int g1 = 350;
            int g2 = 200;
            // tell if the double of g2 is bigger than g1 (print as a boolean)
            Console.WriteLine("g: " + ((g2 * g2) > g1));

            long h = 1357988018575474;
            // tell if it has 11 as a divisor (print as a boolean)
            if (h%11 == 0)

            Console.WriteLine("h: " + (h % 11 == 0));

            int i1 = 10;
            int i2 = 3;
            // tell if i1 is higher than i2 squared and smaller than i2 cubed (print as a boolean)
            if (i1 > (i2 * i2) && i1 < (i2 * i2 * i2))
            {
                Console.WriteLine("i: " + true);
            } else
            {
                Console.WriteLine("i: " + false);
            }

            int j = 1521;
            // tell if j is dividable by 3 or 5 (print as a boolean)
            if (j % 3 == 0 || j % 5 == 0)
            {
                Console.WriteLine("j: " + true);
            } else
            {
                Console.WriteLine("j: " + false);
            }
            
            string k = "Apple";
            //fill the k variable with its content 4 times
            k += k;
            k += k;
            Console.WriteLine("k: " + k);
            Console.ReadLine();
        }
    }
}
