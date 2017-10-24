using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculation<T>
    {
        static dynamic operand1;
        static dynamic operand2;

        public static T Add(string[] args)
        {
            operand1 = Convert.ChangeType(args[0], typeof(T));
            operand2 = Convert.ChangeType(args[2], typeof(T));
            return  operand1 + operand2;
        }

        //public static double Substract(T value1, T value2)
        //{
        //    double? operand1 = value1 as double?;
        //    double? operand2 = value2 as double?;

        //    return operand1 - operand2;
        //}

        //public static T Multiply(T[] args)
        //{
        //    operand1 = (double)args[0];
        //    operand2 = (double)args[2];
        //    return operand1 * operand2;
        //}



        //public static T Divide(T x, T y)
        //    where T : double, int
        //{
        //    return x / y;
        //}
    }
}
