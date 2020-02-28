namespace L5_Task_4
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public class MenyToMenyPeopleToGame : DbContext
    {
        public MenyToMenyPeopleToGame()
            : base("name=Model1")
        {
        }

        
        public virtual DbSet<People> Peoples { get; set; }
        public virtual DbSet<Game> Games { get; set; }
    }
}