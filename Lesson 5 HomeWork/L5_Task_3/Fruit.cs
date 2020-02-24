using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_Task_3
{
    public class Fruit
    {
        public int Id { get; set; }
        public string Property1 { get; set; }
        public string Property2 { get; set; }
        public int? boxId { get; set; }
        public Box box { get; set; }

    }
}
