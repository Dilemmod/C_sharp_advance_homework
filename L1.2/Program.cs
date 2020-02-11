using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyFactory<int> factory = new MyFactory<int>();
            Console.ReadKey();
        }
        public class MyFactory<T> where T : new()
        {
            public static T FacrotyMethod()
            {
                return new T();
            }
        }
    }
}
