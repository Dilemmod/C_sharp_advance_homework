using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main начал работу  в потоке №{0}", Thread.CurrentThread.ManagedThreadId);
            Action act = new Action(PlusWriter);
            Task task = new Task(act);
            //act.Invoke();
            task.Start();
            Action act1 = new Action(MinusWriter);
            task = new Task(act1);
            //act.Invoke();
            task.Start();
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(10);
                Console.Write("!");
            }
            Console.WriteLine("\nMain закончил работу в потоке №{0}\n", Thread.CurrentThread.ManagedThreadId);
            Console.ReadLine();


        }
        static void PlusWriter()
        {
            Console.WriteLine("PlusWriter начал работу в потоке №{0}", Thread.CurrentThread.ManagedThreadId);
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(10);
                Console.Write("+");
            }
            Console.WriteLine("\nPlusWriter закончил работу в потоке №{0}\n", Thread.CurrentThread.ManagedThreadId);
        }
        static void MinusWriter()
        {
            Console.WriteLine("MinusWriter начал работу в потоке №{0}", Thread.CurrentThread.ManagedThreadId);
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(10);
                Console.Write("-");
            }
            Console.WriteLine("\nMinusWriter закончил работу в потоке №{0}\n", Thread.CurrentThread.ManagedThreadId);
        }
    }
}
