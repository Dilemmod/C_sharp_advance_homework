using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Выражение не является валидным потому что DateTime не может иметь значение null, для этого нужно было иницыализировать переменную таким образом:
            DataTime? time = null;
            if (time == null)
            {
                /* do something */
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
