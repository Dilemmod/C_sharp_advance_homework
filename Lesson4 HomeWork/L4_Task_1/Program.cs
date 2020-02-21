using System;

namespace L4_Task_1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter: digit ONE operator digit TWO ");
            dynamic res;
            new Calculator(Console.ReadLine(), out res);
            Console.WriteLine(" = "+res);
            Console.ReadKey();
            Main();
        }
    }
}
