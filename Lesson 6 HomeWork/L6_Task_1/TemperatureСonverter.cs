using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6_Task_1
{
    public class TemperatureСonverter
    {
        public double celsiusTemperature { get; set; }
        public double fahrenheitTemperature { get; set; }
        public double ConvertCelsiusToFahrenheit()
        {
            this.fahrenheitTemperature = celsiusTemperature * 9 / 5 + 32;
            return fahrenheitTemperature;
        }
        public void GetFahrenheit()
        {
            Console.WriteLine("fahrenheit Temperature = " + fahrenheitTemperature);
        }
        public void SetCelsius()
        {
            Console.WriteLine("Enter celsius Temperature: ");
            this.celsiusTemperature = Convert.ToDouble(Console.ReadLine());
        }
    }
}
