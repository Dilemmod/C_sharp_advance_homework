using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_Task_3
{
    class Program
    {
        static void Main()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<OneToMenyBoxToFruit>());
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<OneToMenyBoxToFruit>());

            using (OneToMenyBoxToFruit db = new OneToMenyBoxToFruit())
            {
                Fruit f1 = new Fruit { Name = "Apple", CountryOfManufacture = "Ukrain", Weigth = 2 };
                Fruit f2 = new Fruit { Name = "Banana", CountryOfManufacture = "Africa",Weigth=3};
                Fruit f3 = new Fruit { Name = "Pear", CountryOfManufacture = "Russia",Weigth=4 };
                Fruit f4 = new Fruit { Name = "Plums", CountryOfManufacture = "Ukrain",Weigth=1 };

                db.Fruits.AddRange(new List<Fruit> { f1, f2, f3, f4 });
                db.SaveChanges();

                var fruits = db.Fruits.ToList();

                foreach (var item in fruits)
                {
                    Console.WriteLine("{0}.{1} - Country: {2} Weigth: {3}", item.Id, item.Name, item.CountryOfManufacture, item.Weigth);
                }
                
                Console.WriteLine("-----------------------------------------");
                int weigthFruitBox1=0, weigthFruitBox2 = 0;
                List < Fruit > FruitBox1 =new List<Fruit> { f1, f3, f1, f1, f3 };
                for (int i = 0; i < FruitBox1.Count; i++)
                    weigthFruitBox1 += FruitBox1[i].Weigth;
                List<Fruit> FruitBox2 = new List<Fruit> { f4, f2, f4,f2 };
                for (int i = 0; i < FruitBox2.Count; i++)
                    weigthFruitBox2 += FruitBox2[i].Weigth;

                Box box1 = new Box { CountFruit = FruitBox1.Count, Weight = weigthFruitBox1, Fruit = FruitBox1 };

                Box box2 = new Box { CountFruit = FruitBox2.Count, Weight = weigthFruitBox2, Fruit = FruitBox2 };

                db.Boxs.AddRange(new List<Box> { box1, box2 });
                db.SaveChanges();

                var box = db.Boxs.ToList();

                foreach (var itemBox in box)
                {
                    Console.WriteLine("Box {0}. - Count of fruit: {1}, Weigth: {2}", itemBox.Id, itemBox.CountFruit, itemBox.Weight);

                    if (itemBox.Fruit == null) continue;

                    foreach (var itemFr in itemBox.Fruit)
                    {
                        Console.WriteLine("Name:{0} - Country{1}, Weigth: {2}", itemFr.Name, itemFr.CountryOfManufacture, itemFr.Weigth);
                    }

                    Console.WriteLine("-----------------------------------------");
                }
                
                Console.ReadKey();

            }
        }
    }
}
