namespace L5_Task_3
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class OneToMenyBoxToFruit : DbContext
    {
        public OneToMenyBoxToFruit()
            : base("name=Model1")
        {
        }
        public virtual DbSet<Box> Boxs { get; set; }
        public virtual DbSet<Fruit> Fruits { get; set; }
    
    }
}