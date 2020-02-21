using System;
using System.Collections.Generic;
using System.Text;

namespace L4_Task_1
{
    class Calculator
    {
        public Calculator(string example, out dynamic res)
        {
            res = "";
            int plus = example.IndexOf("+"),minus = example.IndexOf("-"), multiple = example.IndexOf("*"), share = example.IndexOf("/");
            string[] exa = example.Split(new char[] { '+','-','*','/' });
            double[] doubleExa = { Convert.ToDouble(exa[0]), Convert.ToDouble(exa[0]) };
            if (plus != -1)
            {
                res=Plus(doubleExa[0], doubleExa[1]);
            }
            else if (minus != -1)
            {
                res = Minus(doubleExa[0], doubleExa[1]);
            }
            else if (multiple != -1)
            {
                res = Multiple(doubleExa[0], doubleExa[1]);
            }
            else if (share != -1)
            {
                res = Share(doubleExa[0], doubleExa[1]);
            }
        }
        dynamic Plus(dynamic one,dynamic two)
        {
            return one + two;
        }
        dynamic Minus(dynamic one, dynamic two)
        {
            return one - two;
        }
        dynamic Multiple(dynamic one, dynamic two)
        {
            return one * two;
        }
        dynamic Share(dynamic one, dynamic two)
        {
            if (two == 0)
            {
                Console.WriteLine("You can not do it this way");
                return 0;
            }
            else
            {
                return one / two;
            }
        }

    }
}
