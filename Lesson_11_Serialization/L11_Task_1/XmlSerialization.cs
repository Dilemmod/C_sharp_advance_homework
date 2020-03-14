using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace L11_Task_1
{
    class XmlSerialization
    {
        public XmlSerializer serializer = new XmlSerializer(typeof(SerializationClass));

        //SerializationClass instance1 = new SerializationClass();

        SerializationClass instance2;
        public void Serialization(SerializationClass instance1)
        {
            FileStream stream = new FileStream("Serialization.xml",FileMode.Create, FileAccess.Write, FileShare.Read);

            serializer.Serialize(stream, instance1);

            Console.WriteLine( "Объект сериализован!");

            stream.Close();
        }
       
        public void Deserialization()
        {
            try
            {
                FileStream stream = new FileStream("Serialization.xml", FileMode.Open, FileAccess.Read,FileShare.Read);

                instance2 = serializer.Deserialize(stream) as SerializationClass;
                Console.WriteLine("Объект Десериализован!");

                Console.WriteLine("R = {0}",instance2.R);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
