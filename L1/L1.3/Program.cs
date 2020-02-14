using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator<int, int> calcInt = new Calculator<int, int>();
            Console.WriteLine(calcInt.Plus(4, 3));
            Calculator<double, string> calcStr = new Calculator<double, string>();
            Console.WriteLine(calcStr.Multiply(4.8, "5"));
            Calculator<float, float> calcFl = new Calculator<float, float>();
            Console.WriteLine(calcFl.Minus(7.2f, 5.4f));
        }
        class Calculator<T1, T2>
        {
            public double Plus(T1 t1, T2 t2)
            {
                return Convert.ToDouble(t1) + Convert.ToDouble(t2);
            }
            public double Minus(T1 t1, T2 t2)
            {
                return Convert.ToDouble(t1) - Convert.ToDouble(t2);
            }
            public double Multiply(T1 t1, T2 t2)
            {
                return Convert.ToDouble(t1) * Convert.ToDouble(t2);
            }
        }
    }
}
