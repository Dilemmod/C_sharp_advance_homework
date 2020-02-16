using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Book<string> bookStr = new Book<string>("Book1", "200");
            Book<int> bookInt = new Book<int>("Book2", 200);
            Console.ReadLine();
        }
        class Book<T>
        {
            private string Name { set; get; }
            private T Price { set; get; }
            public Book(string name, T price)
            {
                this.Name = name;
                this.Price = price;
                Show();
            }
            private void Show()
            {
                Console.WriteLine("Name = " + Name + "; Price = " + Price);
            }
        }
    }
}
