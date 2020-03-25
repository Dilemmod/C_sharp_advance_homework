using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Func<long> func =new Func<long>(PLINQMetod);
            Task<long> task = new Task<long>(func);
            task.Start();
            
            Stopwatch timer = new Stopwatch();
            timer.Start();
            Console.WriteLine("Начал работу LINQ в потоке №{0}", Thread.CurrentThread.ManagedThreadId);
            int[] randArrey = new int[100000000];

            for (int i = 0; i < randArrey.Length; i++)
                randArrey[i] = rand.Next(0, 100);

            var LinqOdd = from element in randArrey
                            where element % 2 != 0
                            select element;
            int[] arreyLinqOdd = LinqOdd.ToArray();
            Console.WriteLine("First Numbers of ArreyLinqOdd:  ");
            for (int i = 0; i < 10; i++)
                Console.Write(arreyLinqOdd[i]+", ");

            timer.Stop();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\t\t\t\t\tВремя выполнения           LINQ и for : " + timer.ElapsedMilliseconds);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Закончил работу LINQ в потоке №{0}\n\n", Thread.CurrentThread.ManagedThreadId);
            long linqTime = timer.ElapsedMilliseconds;
            long plinqTime = task.Result;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(plinqTime < linqTime? "PLINQ и Parallel.For быстрее обычного Linq и for на :\n" + (linqTime - plinqTime)+ " миллисекунд" : "Linq и for быстрее PLINQ и Parallel.For на :\n" + (plinqTime - linqTime)+ " миллисекунд");

            Console.ReadLine();

        }
        static long PLINQMetod()
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            Console.WriteLine("Начал работу PLINQ в потоке №{0}", Thread.CurrentThread.ManagedThreadId);
            Random rand = new Random();

            int[] randArrey = new int[100000000];

            Parallel.For(0, randArrey.Length, (i) => randArrey[i] = rand.Next(0,100));

            var PlinqOdd = from element in randArrey.AsParallel()
                            where element % 2 != 0
                            select element;
            int[] arreyPlinqOdd = PlinqOdd.ToArray();

            Console.WriteLine("First Numbers of ArreyPlinqOdd:  ");
            Parallel.For(0, 10, (i) => Console.Write(arreyPlinqOdd[i]+", "));

            timer.Stop();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\t\t\t\t\tВремя выполнения PLINQ и Parallel.For : " + timer.ElapsedMilliseconds);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Закончил работу PLINQ в потоке №{0}\n\n", Thread.CurrentThread.ManagedThreadId);
            return timer.ElapsedMilliseconds;


        }
    }
}
