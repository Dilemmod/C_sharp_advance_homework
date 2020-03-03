using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6_Task_1
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
