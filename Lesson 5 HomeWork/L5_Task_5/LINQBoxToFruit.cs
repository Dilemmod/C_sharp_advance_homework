namespace L5_Task_5
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class LINQBoxToFruit : DbContext
    {
        public LINQBoxToFruit()
            : base("name=Model1")
        {
        }
        public virtual DbSet<Box> Boxs { get; set; }
        public virtual DbSet<Fruit> Fruits { get; set; }

    }
}