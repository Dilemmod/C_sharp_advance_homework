using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using L8_Task_1;

namespace Task_2
{
    class Program
    {
        static void Main()
        {
            XDocument document = XDocument.Load("TelephoneBook.xml");

            foreach (XElement Element in document.Element("MyContacts").Elements("Contact"))
            {
                XAttribute NameElement = Element.Attribute("Name");
                XAttribute NumberElement = Element.Attribute("TelephoneNumber");

                Console.WriteLine(string.Format($"Name            : {NameElement.Value}"));
                Console.WriteLine(string.Format($"Telephone Number: {NumberElement.Value}"));

                Console.WriteLine(Environment.NewLine);
            }

            Console.WriteLine(new string('-', 30));
            Console.ReadLine();
        }
    }
}
