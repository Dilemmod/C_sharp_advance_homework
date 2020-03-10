using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Programmer p = new Programmer("Tom", 500);
            Manager m = new Manager("Mark", 700);
            Director d = new Director("BOSS", 8000);

            Console.WriteLine(protectedSection(p.type));
            Console.WriteLine(protectedSection(m.type));
            Console.WriteLine(protectedSection(d.type));
            Console.WriteLine(new string('-',30));
            Console.WriteLine(protectedSection(p.type, 3));
            Console.WriteLine(protectedSection(p.type, 2));
            Console.WriteLine(new string('-', 30));
            Console.WriteLine(protectedSection(m.type, 2));
            Console.WriteLine(protectedSection(m.type, 1));
            Console.WriteLine(new string('-', 30));
            Console.WriteLine(protectedSection(d.type, 1));

            Console.Read();
        }
        static string protectedSection(Type t)
        {
            object[] atEmployers = t.GetCustomAttributes(false);
            foreach (AccessLevelAttribute atEmp in atEmployers)
            {
                return t.Name+" have "+atEmp.level+" level acces";
            }
            return "";
        }
        static string protectedSection(Type t, int neededAccesLevel)
        {
            object[] atEmployers = t.GetCustomAttributes(false);
            foreach (AccessLevelAttribute atEmp in atEmployers)
            {
                if (atEmp.level <= neededAccesLevel)
                    return t.Name + " have acces to file with " + neededAccesLevel + " level";
                else
                    return t.Name + " dont have acces to file with " + neededAccesLevel + " level";
            }
            return "";
        }
       // [AccessLevel(3)]
        class Employer
        {
            public string name { get; set; }
            public int salary { get; set; }
            public Employer(string name, int salary)
            {
                this.name = name;
                this.salary = salary;
            }
        }
       
        [AccessLevel(3)]
        class Programmer : Employer
        {
            public Type type
            {
                get
                {
                    return typeof(Programmer);
                }
            }
            public Programmer(string name, int salary) : base(name, salary)
            {
            }

        }
        [AccessLevel(2)]
        class Manager : Employer
        {
            public Type type
            {
                get
                {
                    return typeof(Manager);
                }
            }
            public Manager(string name, int salary) : base(name, salary)
            {
            }
        }
        [AccessLevel(1)]
        class Director : Employer
        {
            public Type type
            {
                get
                {
                    return typeof(Director);
                }
            }
            public Director(string name, int salary) : base(name, salary)
            {
            }
        }
    }
}
