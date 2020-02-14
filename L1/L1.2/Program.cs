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
            MyFactory<Test>.FacrotyMethod();
            MyFactory<int>.FacrotyMethod();
            MyFactory<object>.FacrotyMethod();
            MyFactory<double>.FacrotyMethod();
            Console.ReadKey();
        }
        public class Test
        {

        }
        public class MyFactory<T> where T : new()
        {
            public static T FacrotyMethod()
            {
                MyFactory<T> type = new MyFactory<T>();
                Console.WriteLine(type.GetType());
                return new T();
            }
        }
    }
}
