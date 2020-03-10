#define New

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main()
        {
            MyClass.OldMetod();
            MyClass.NewMetod();
       
            Console.ReadKey();
        }
      
        class MyClass
        {
            public string stringProperty { get; set; }
            public int intProperty { get; set; }

            public MyClass(string stringArgument, int intArgument)
            {
                this.stringProperty = stringArgument;
                this.intProperty = intArgument;
            }
            [Conditional("Old")]
            [Obsolete("This method is obsolete")]
            public static void OldMetod()
            {
                Console.WriteLine( "You have called OldMethod."); 
            }
            [Conditional("New")]
            public static void NewMetod()
            {
                Console.WriteLine( "You have called NewdMethod.");
            }
        }
    }
}
