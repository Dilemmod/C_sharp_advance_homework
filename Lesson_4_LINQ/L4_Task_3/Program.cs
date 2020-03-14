using System;
using System.Linq;

namespace L4_Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] numbers = new int[30];
            for (int i = 0; i < 30; i++)
            {
                numbers[i] = rand.Next(-30, 30);
            }
            var positNum = from x in numbers
                           where x >= 0
                           select x;
            var negativeNum = from x in numbers
                           where x < 0
                           select x;
            foreach (var item in numbers)
                Console.Write(item + ", ");
            Console.WriteLine();
            Console.WriteLine("First positiv digit = " + positNum.First());
            Console.WriteLine("Last negative digit = " + negativeNum.Last());

            Console.ReadLine();
        }
    }
}
