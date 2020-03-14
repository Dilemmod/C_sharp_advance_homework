using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_Task_5
{
    public class Box
    {
        public int Id { get; set; }
        public int Weight { get; set; }
        public int CountFruit { get; set; }
        public ICollection<Fruit> Fruit { get; set; }
        public Box()
        {
            Fruit = new List<Fruit>();
        }
    }
}
