using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_Task_3
{
    public class Box
    {
        public int Id { get; set; }
        public string Property1 { get; set; }
        public string Property2 { get; set; }
        public string Property3 { get; set; }
        public ICollection<Fruit> Fruit { get; set; }
        public Box()
        {
            Fruit = new List<Fruit>();
        }
    }
}
