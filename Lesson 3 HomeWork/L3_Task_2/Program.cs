using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3_Task_2
{
    delegate double MyDelegate(double x, double y);
    class Program
    {
        static void Main()
        {
            MyDelegate myAddition = (x, y) => x + y;
            MyDelegate myMultiplication = (x, y) => x * y;
            MyDelegate mySubtraction = (x, y) => x - y;
            MyDelegate myDivision = (x, y) =>
            {
                Console.WriteLine((y==0?"FAIL, division by zero":""));
                return (y == 0 ? 0 : x / y);
            };
            Console.WriteLine("Enter:     digit one     sign     digit two");
            string example =  Console.ReadLine();
            char act = (example.IndexOf("+") != -1 ? '+' : (example.IndexOf("-") != -1 ? '-':(example.IndexOf("*") != -1 ? '*':(example.IndexOf("/") != -1 ? '/':'0'))));
            string[] numbers = example.Split(new char[] { act });
            try
            {
                double one = Convert.ToDouble(numbers[0]), two = Convert.ToDouble(numbers[1]);
                switch (act)
                {
                    case '+':
                        Console.Write(" = " + myAddition(one, two));
                        break;
                    case '-':
                        Console.Write(" = " + mySubtraction(one, two));
                        break;
                    case '*':
                        Console.Write(" = " + myMultiplication(one, two));
                        break;
                    case '/':
                        Console.Write(" = " + myDivision(one, two));
                        break;
                    default:
                        Console.WriteLine("FAIL, you did not enter any sign!");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("FAIL, wrong input");
                Main();
            }
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();
            Main();
            Console.ReadKey();
        }
    }
}
