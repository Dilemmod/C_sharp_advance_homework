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
            XElement ContactList = new XElement("MyContacts");
            ContactList.Add(new XElement("Contact", new XAttribute("Name", "Sashko"), new XAttribute("TelephoneNumber", "3809522247")));
            ContactList.Add(new XElement("Contact", new XAttribute("Name", "Masha"), new XAttribute("TelephoneNumber", "3809555557")));
            ContactList.Add(new XElement("Contact", new XAttribute("Name", "Nina"), new XAttribute("TelephoneNumber", "3809777777")));
            ContactList.Add(new XElement("Contact", new XAttribute("Name", "Lexus"), new XAttribute("TelephoneNumber", "3809539442")));
            ContactList.Add(new XElement("Contact", new XAttribute("Name", "Costya"), new XAttribute("TelephoneNumber", "3809532323")));
            ContactList.Add(new XElement("Contact", new XAttribute("Name", "Nastya"), new XAttribute("TelephoneNumber", "3809333766")));
            //XElement NameAtribut = new XElement("Name", "Sashko");
            //XElement NumberAtribut = new XElement("TelephoneNumber", "3809522247");
            //XElement Contact = new XElement("Contact");
            //Contact.Add(NameAtribut);
            //Contact.Add(NumberAtribut);
            //NameAtribut.Add("Name", "Masha");


            //List<XElement> listElement = new List<XElement>
            //{
            //    new XElement("Name", "Sashko"),
            //        new XElement("TelephoneNumber", "3809522247"),
            //    new XElement("Name", "Masha"),
            //         new XElement("TelephoneNumber", "3809555557"),
            //    new XElement("Name", "Nina"),
            //        new XElement("TelephoneNumber", "3809777777"),
            //    new XElement("Name", "Lexus"),
            //         new XElement("TelephoneNumber", "3809539442"),
            //    new XElement("Name", "Costya"),
            //        new XElement("TelephoneNumber", "3809532323"),
            //    new XElement("Name", "Nastya"),
            //        new XElement("TelephoneNumber", "3809333766")
            //};
            //List<XElement> listElementName = new List<XElement>
            //{
            //    new XElement("Name", "Sashko"),
            //    new XElement("Name", "Masha"),
            //    new XElement("Name", "Nina"),
            //    new XElement("Name", "Lexus"),
            //    new XElement("Name", "Costya"),
            //    new XElement("Name", "Nastya"),
            //};

            //List<XElement> listElementNumber = new List<XElement>
            //{
            //    new XElement("TelephoneNumber", "3809522247"),
            //    new XElement("TelephoneNumber", "3809555557"),
            //    new XElement("TelephoneNumber", "3809777777"),
            //    new XElement("TelephoneNumber", "3809539442"),
            //    new XElement("TelephoneNumber", "3809532323"),
            //    new XElement("TelephoneNumber", "3809333766")
            //};
            //List<XElement> Contact = new List<XElement>()
            //{
            //    new XElement("Contact")
            //};

            string nameFile = "TelephoneBook.xml";
            //try
            //{
                //for (int i = 0; i < 6; i++)
                //{
                //    Contact.Add(listElementName[i]);
                //    Contact.Add(listElementNumber[i]);
                //    ContactList.Add(Contact);
                //    Contact.Clear();
                //}
            xdoc.Add(ContactList);
            xdoc.Save(nameFile);

            Console.WriteLine("Successfully created "+ nameFile + " file.");
            
            //catch
            //{
            //    Console.WriteLine("Fail");
            //}

            Console.ReadKey();
        }
    }
}
