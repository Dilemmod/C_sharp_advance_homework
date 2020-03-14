using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10_Task_2
{
    extern alias L1;
    class Program
    {
        
        static void Main(string[] args)
        {
            L1.Library1.Class1 cl = new L1.Library1.Class1();
            Console.WriteLine(cl.Metod());
            Console.ReadKey();

        }
    }
}
