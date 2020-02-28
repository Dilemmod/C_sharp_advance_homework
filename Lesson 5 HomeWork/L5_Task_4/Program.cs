using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_Task_4
{
    class Program
    {
        static void Main()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<MenyToMenyPeopleToGame>());
            using (MenyToMenyPeopleToGame db = new MenyToMenyPeopleToGame())
            {
                People p1 = new People { FirstName = "Clara", LastName = "Jonson" };
                People p2 = new People { FirstName = "Mike", LastName = "Vasinski" };
                People p3 = new People { FirstName = "Jon", LastName = "Uick" };
                People p4 = new People { FirstName = "Kerl", LastName = "Linson" };
                People p5 = new People { FirstName = "Leroy", LastName = "Jenkins" };

                db.Peoples.AddRange(new List<People> { p1, p2, p3, p4, p5 });
                db.SaveChanges();
                Game g1 = new Game { Name = "GTA6         ", Price = 999 };
                g1.People.Add(p2);
                g1.People.Add(p3);
                Game g2 = new Game { Name = "Crisis5      ", Price = 37 };
                g2.People.Add(p1);
                g2.People.Add(p2);
                g2.People.Add(p3);
                g2.People.Add(p4);
                g2.People.Add(p5);
                Game g3 = new Game { Name = "Lara Croft 8 ", Price = 199 };
                g3.People.Add(p1);
                g3.People.Add(p2);
                g3.People.Add(p4);
                Game g4 = new Game { Name = "Sties Skilines", Price = 100 };
                g4.People.Add(p1);
                g4.People.Add(p5);
                g4.People.Add(p2);
                g4.People.Add(p4);
                db.Games.AddRange(new List<Game> { g1, g2, g3, g4 });
                db.SaveChanges();

                Console.WriteLine("What games did these people played: \n");
                foreach (var itemP in db.Peoples.Include(p => p.Game))
                {
                    Console.WriteLine("{0}. {1} {2}.", itemP.Id, itemP.LastName,itemP.FirstName.Substring(0,1).ToUpper() );

                    if (itemP.Game == null) continue;

                    foreach (var itemG in itemP.Game)
                    {
                        Console.WriteLine("\t{0}\t Price:{1}",itemG.Name, itemG.Price);
                    }
                    Console.WriteLine(new string('-',30));
                }

                Console.SetCursorPosition(50, 0);
                Console.WriteLine("What people played these games: \n");

                int position = 1;  
                foreach (var itemG in db.Games.Include(g => g.People))
                {
                    Console.SetCursorPosition(50, ++position);
                    Console.WriteLine("{0}. {1}\t Price:{2}", itemG.Id, itemG.Name, itemG.Price);

                    if (itemG.People == null) continue;

                    foreach (var itemP in itemG.People)
                    {
                        Console.SetCursorPosition(50, ++position);
                        Console.WriteLine("\t{0} {1}.", itemP.FirstName, itemP.LastName);
                    }
                    Console.SetCursorPosition(50, ++position);
                    Console.WriteLine(new string('-', 30));

                }
                Console.ReadLine();
            }
        }
    }
}
