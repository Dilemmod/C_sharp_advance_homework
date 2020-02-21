using System;
using System.Collections.Generic;
using System.Text;

namespace L4_Task_4
{
    class CustomerFitnessCenter
    {
        public int code { get; set; }
        public int year { get; set; }
        public int monthNumber { get; set; }
        public int classDuration { get; set; }
        public override string ToString()
        {
            return "Code custumers: "+code+"\nClass duration: " + classDuration + "\nYear: " + year + "\nMonth Number: " + monthNumber + "\n";
        }

    }
}
