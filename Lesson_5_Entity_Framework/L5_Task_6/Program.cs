using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_Task_5
{
    class Program
    {
        public LINQBoxToFruit db;
        static void Main()
        {
           Database.SetInitializer(new DropCreateDatabaseAlways<LINQBoxToFruit>());
           

            using (LINQBoxToFruit db = new LINQBoxToFruit())
            {
                Fruit f1 = new Fruit { Name = "Plums", CountryOfManufacture = "Ukrain", Weigth = 1 };
                Fruit f2 = new Fruit { Name = "Banana", CountryOfManufacture = "Africa", Weigth = 2 };
                Fruit f3 = new Fruit { Name = "Pear", CountryOfManufacture = "Russia", Weigth = 3 };
                Fruit f4 = new Fruit { Name = "Apple", CountryOfManufacture = "Ukrain", Weigth = 4 };

                db.Fruits.AddRange(new List<Fruit> { f1, f2, f3, f4 });
                db.SaveChanges();
                int weigthFruitBox1 = 0, weigthFruitBox2 = 0, weigthFruitBox3 = 0;
                List<Fruit> FruitBox1 = new List<Fruit> { f2, f2, f2, f2, f2 };//10
                for (int i = 0; i < FruitBox1.Count; i++)
                    weigthFruitBox1 += FruitBox1[i].Weigth;
                List<Fruit> FruitBox2 = new List<Fruit> { f1, f1, f1, f1, f1, f3 };//8
                for (int i = 0; i < FruitBox2.Count; i++)
                    weigthFruitBox2 += FruitBox2[i].Weigth;
                List<Fruit> FruitBox3 = new List<Fruit> { f4, f4, f4, f4 };//16
                for (int i = 0; i < FruitBox3.Count; i++)
                    weigthFruitBox3 += FruitBox3[i].Weigth;

                Box box1 = new Box { CountFruit = FruitBox1.Count, Weight = weigthFruitBox1, Fruit = FruitBox1 };
                Box box2 = new Box { CountFruit = FruitBox2.Count, Weight = weigthFruitBox2, Fruit = FruitBox2 };
                Box box3 = new Box { CountFruit = FruitBox3.Count, Weight = weigthFruitBox3, Fruit = FruitBox3 };

                db.Boxs.AddRange(new List<Box> { box1, box2, box3 });
                db.SaveChanges();

                var box = db.Boxs.ToList();
                Console.WriteLine("Base table:\n");
                foreach (var itemBox in box)
                {
                    Console.WriteLine("Box {0}. - Count of fruit: {1}, Weigth: {2}", itemBox.Id, itemBox.CountFruit, itemBox.Weight);

                    if (itemBox.Fruit == null) continue;

                    foreach (var itemFr in itemBox.Fruit)
                    {
                        Console.WriteLine("N: {0} - C: {1}, Weigth: {2}", itemFr.Name, itemFr.CountryOfManufacture, itemFr.Weigth);
                    }
                    Console.WriteLine(new string('-', 10));
                }


                var find = db.Boxs.Find(2);
                    Console.WriteLine("Find by Id = 2:\n\tBox {0}. - Count of fruit: {1}, Weight: {2}", find.Id, find.CountFruit, find.Weight);
                var include = db.Boxs.Include(b => b.Fruit).ToList();
                    Console.WriteLine("Include Fruit:\n");
                foreach (var itemBox in include)
                {
                    Console.WriteLine("\tBox {0}. - Count of fruit: {1}, Weight: {2}", itemBox.Id, itemBox.CountFruit, itemBox.Weight);
                }
                var select = db.Boxs.Select(b => new
                {
                    b.Weight,
                    b.Id,
                    b.CountFruit
                });
                Console.WriteLine("Select: ");
                foreach (var itemBox in select)
                {
                    Console.WriteLine("\tBox {0}. - Count of fruit: {1}, Weight: {2}", itemBox.Id, itemBox.CountFruit, itemBox.Weight);
                }
               
                
                Console.ReadKey();

            }
        }
    }
}
