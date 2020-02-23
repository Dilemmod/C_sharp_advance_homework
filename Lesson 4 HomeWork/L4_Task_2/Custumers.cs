using System;
using System.Collections.Generic;
using System.Text;

namespace L4_Task_2
{
    class Custumers<T>
    {
        public T auto { get; set; }
        public string name { get; set; }
        public string numberPhone { get; set; }
        public override string ToString()
        {
            return "Auto:\n " + auto + "\nBuyer's name: " + name + "\nBuyer's number Phone: " + numberPhone + "\n\n";
        }
    }
}
