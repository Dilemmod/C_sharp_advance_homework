using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace L8_Task_1
{
    class Program
    {
        static void Main()
        {

            XDocument xdoc = new XDocument();
            XElement Contacts = new XElement("MyContacts");
            Contacts.Add(new XElement("Contact", new XAttribute("Name", "Sashko"), new XAttribute("TelephoneNumber", "3809522247")));
            Contacts.Add(new XElement("Contact", new XAttribute("Name", "Masha"), new XAttribute("TelephoneNumber", "3809555557")));
            Contacts.Add(new XElement("Contact", new XAttribute("Name", "Nina"), new XAttribute("TelephoneNumber", "3809777777")));
            Contacts.Add(new XElement("Contact", new XAttribute("Name", "Lexus"), new XAttribute("TelephoneNumber", "3809539442")));
            Contacts.Add(new XElement("Contact", new XAttribute("Name", "Costya"), new XAttribute("TelephoneNumber", "3809532323")));
            Contacts.Add(new XElement("Contact", new XAttribute("Name", "Nastya"), new XAttribute("TelephoneNumber", "3809333766")));
           
            string nameFile = "TelephoneBook.xml";
           
            xdoc.Add(Contacts);
            xdoc.Save(nameFile);

            Console.WriteLine("Successfully created " + nameFile + " file.");

            Console.ReadKey();
        }
    }
}
