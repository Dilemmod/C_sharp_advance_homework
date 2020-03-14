using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L11_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            SerializationClass serClass = new SerializationClass();
            serClass.GetRandomR();
            XmlSerialization xmlS = new XmlSerialization();
            xmlS.Serialization(serClass);
            xmlS.Deserialization();
            Console.ReadKey();
        }
    }
     public class SerializationClass
     {
         Random rand = new Random();
         public int R { get; set; }
         public void GetRandomR()
         {
             R = rand.Next(0, 50);
            Console.WriteLine(R);
         }
     }
}
