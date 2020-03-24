using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace L13_Task_1
{
    class Program
    {
        static int counter = 0;
        static void Main()
        {
            InfinityMetod();
            Console.ReadKey();
        }
        static void InfinityMetod()
        {
            while (counter < 5)
            {
                Console.WriteLine("Thread Id {0}, counter = {1}", Thread.CurrentThread.GetHashCode(), counter);
                counter++;
                Thread.Sleep(200);
            }
            Console.WriteLine(new string('-',30));
            counter = 0;

            
            Thread thread = new Thread(InfinityMetod);
            thread.Start();

        }
    }
}
