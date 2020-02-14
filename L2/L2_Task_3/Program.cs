using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_Task_3
{
    class Program
    {
        static void Main()
        {

            SortedList<string, int> sortList = new SortedList<string, int>();
            sortList.Add("w", 2);
            sortList.Add("r", 6);
            sortList.Add("b", 8);
            sortList.Add("a", 0);
            sortList.Add("h", 1);
            sortList.Add("c", 3);
            sortList.Add("d", 2);

            Console.WriteLine("Sorted Up");
            foreach(var i in sortList)
                Console.WriteLine("Key: " + i.Key + "; Value: " + i.Value);

            Console.WriteLine("Sorted Down");
            foreach (var i in sortList.Reverse())
                Console.WriteLine("Key: " + i.Key + "; Value: " + i.Value);

            Console.ReadLine();
        }
    }
}
