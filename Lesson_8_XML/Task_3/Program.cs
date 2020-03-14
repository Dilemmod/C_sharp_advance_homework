using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using L8_Task_1;

namespace Task_3
{
    class Program
    {
        static void Main()
        {
            XDocument document = XDocument.Load("TelephoneBook.xml");

            foreach (XElement Element in document.Element("MyContacts").Elements("Contact"))
            {
                Console.WriteLine(string.Format($"{ Element.Attribute("TelephoneNumber")}"));
            }

            Console.WriteLine(new string('-', 30));
            Console.ReadLine();
        }
    }
}
