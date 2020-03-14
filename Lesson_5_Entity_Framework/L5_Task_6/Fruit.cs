using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_Task_5
{
    public class Fruit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CountryOfManufacture { get; set; }
        public int Weigth { get; set; }
        public int? boxId { get; set; }
        public Box box { get; set; }

    }
}
