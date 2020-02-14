using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_Task_1
{
    /* 
    1.
   Используя Visual Studio, создайте проект по шаблону Console Application.
   Создайте програму в которой реализуйте коллекцию MyList<T>. Реализуйте в простейшем приближении возможность использования ее экземпляра аналогично экземпляру класса List<T>.
   Для данной задачи создайте обобщенный интерфейс IMyList<T>, интерфейс должен содержать следующие методы и свойства:
   1) Метод void Add(T a); - для добавления элемента в коллекцию;
   2) T this[int index] { get; } свойство – для получения элемента массива из коллекции по индексу;
   3) int Count { get; } свойство которое возвращает количество элементов массива;
   4) Метод void Clear(); - удаляет из коллекции все элементы;
   5) Метод bool Contains(T item); - определяет содержится ли элемент в коллекции.
   Далее создайте обобщенный класс MyList<T> (экземпляр которой и будет использоватся аналогично экземпляру List<T>.), в котором реализуйте интерфейс IMyList<T> также в теле класса создайте закрытий массив элементов типа Т - private T[] array и конструктор класса public MyList() в котором инициализируйте массив элементов.
   Далее в методе Main создайте экземпляр коллекции MyList<T> и циклом добавьте в него 20 элементов, после чего в цикле переберите все его элементы и выведите их значение на консоль.
    */
    /*
     2.
    Используя Visual Studio, создайте про.ект по шаблону Console Application.
    Создайте расширяющий метод: public static T[] GetArray<T>(this MyList<T> list) Примените расширяющий метод к экземпляру типа MyList<T>, разработанному в домашнем задании 2 для данного урока. Выведите на экран значения элементов массива, который вернул расширяющий метод GetArray()        
     */
    class Program
    {
        static void Main()
        {
            MyList<int> myList = new MyList<int>();
            Random rand = new Random();
            for(int i = 0; i <19 ; i++)
                myList.Add(rand.Next(0,20));

            myList.Add(8);
            int num = 8;
            Console.Write("number " + num);
            Console.WriteLine(myList.Contains(num)==false? " is not in the array": " is in the array");
            
            for (int i = 0; i < myList.Count; i++)
                Console.Write(myList[i]+", ");
            //myList.Clear();

            int[] test = Expansion.GetArray<int>(myList);
            Console.WriteLine();
            foreach(var temp in test)
                Console.Write(temp+", ");
            Console.ReadKey();
        }


    }
}
