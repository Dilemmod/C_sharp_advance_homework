using System;
using System.Collections.Generic;
using System.Linq;

namespace L4_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Auto> listAuto = new List<Auto>()
            {
                new Auto{mark="Lamborghini", model="Aventador",color="Red",yearOfGraduation="2011"},
                new Auto{mark="Ferrari", model="LaFerrari",color="Blue",yearOfGraduation="2013"},
                new Auto{mark="Porsche", model="Taycan",color="Black",yearOfGraduation="2015"},
                new Auto{mark="Bugatti", model="Veyron Super Sport",color="Black",yearOfGraduation="2015"},
                new Auto{mark="Mclaren", model="F1",color="Orange",yearOfGraduation="1993"}
            };
            List<Custumers<Auto>> listCustumers = new List<Custumers<Auto>>()
            {
                new Custumers<Auto>{auto=listAuto[0],name="Carl",numberPhone="32999999"},
                new Custumers<Auto>{auto=listAuto[1],name="Niko",numberPhone="12227778"},
                new Custumers<Auto>{auto=listAuto[3],name="Niko",numberPhone="312423777"},
                new Custumers<Auto>{auto=listAuto[4],name="Leroyi",numberPhone="129991212"}
            };
            //IOrderedEnumerable<out Custumers<Auto>>
            var query =
                       from custumer in listCustumers
                       where custumer.name == "Niko"
                       orderby custumer.name, custumer.numberPhone, custumer.auto
                       select custumer;
            Console.WriteLine();
            int i = 0;
            foreach (var item in query)
            {
                Console.WriteLine("Number: " + (++i));
                Console.WriteLine(item);
            }
        }
       
    }
}
