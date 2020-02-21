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
            char oper = (example.IndexOf("+") != -1 ? '+':(example.IndexOf("-") != -1 ? '-':(example.IndexOf("*") != -1 ? '*':(example.IndexOf("/") != -1 ? '/':'+'))));
            string[] exa = example.Split(new char[] { oper });
            double[] doubleExa = { Convert.ToDouble(exa[0]), Convert.ToDouble(exa[0]) };
            if (oper=='+')
            {
                res=Plus(doubleExa[0], doubleExa[1]);
            }
            else if (oper=='-')
            {
                res = Minus(doubleExa[0], doubleExa[1]);
            }
            else if (oper=='*')
            {
                res = Multiple(doubleExa[0], doubleExa[1]);
            }
            else if (oper=='/')
            {
                res = Share(doubleExa[0], doubleExa[1]);
            }
        }
        dynamic Plus(dynamic one, dynamic two)
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
