using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3_Task_1
{
    delegate int MyDelegate(int one, int two, int three);
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate myAnonim = delegate (int x, int y, int z) { return (x + y + z) / 3; };
            MyDelegate myDelegate = myAnonim;
            Console.WriteLine(myDelegate(12,5,6));
            Console.ReadLine();

        }
    }
}
