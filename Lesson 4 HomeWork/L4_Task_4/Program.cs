using System;
using System.Linq;

namespace L4_Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            CustomerFitnessCenter[] custumers = new CustomerFitnessCenter[8];
            int temp = 1,minClassDuration=0;
            for (int i = 0; i < custumers.Length; i++)
            {
                custumers[i] = new CustomerFitnessCenter()
                {
                    code = i + 1,
                    year = rand.Next(2016, 2020),
                    monthNumber = rand.Next(1, 13),
                    classDuration = rand.Next(1, 7)
                };
                minClassDuration = (temp > custumers[i].classDuration ? custumers[i].classDuration : temp);
                temp = custumers[i].classDuration;
            }
            var query = from custumer in custumers
                        where custumer.classDuration == minClassDuration
                        select custumer;
            Console.WriteLine("All Custumers:\n");
            foreach (var item in custumers)
                Console.WriteLine(item);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("Custumers whith minimum duration of classes:\n");
            foreach(var item in query)
                Console.WriteLine("Class duration: " + item.classDuration + "\nYear: " + item.year + "\nMonth Number: " + item.monthNumber+"\n");
            Console.WriteLine(new string('-', 20));
            var last = query.Last();
            Console.WriteLine("Last custumer whith minimum duration of classes:");
            Console.WriteLine("\nClass duration: " + last.classDuration + "\nYear: " + last.year + "\nMonth Number: " + last.monthNumber + "\n");
            Console.ReadKey();
        }
    }
}
