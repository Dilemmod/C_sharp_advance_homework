using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using L6_Task_1;

namespace L6_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            TemperatureСonverter tempConv = new TemperatureСonverter();
            tempConv.SetCelsius();
            tempConv.ConvertCelsiusToFahrenheit();
            tempConv.GetFahrenheit();
            Console.ReadKey();
        }
    }
}
