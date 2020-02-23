using System;
using System.Collections.Generic;
using System.Text;

namespace L4_Task_2
{
    class Auto
    {
        public string mark { get; set; }
        public string model { get; set; }
        public string yearOfGraduation { get; set; }
        public string color { get; set; }
        public override string ToString()
        {
            return "\tMark: " + mark + "\n\tModel: " + model + "\n\tColor: " + color + "\n\tYear Of Graduation: " + yearOfGraduation + "\n";
        }
    }
}
