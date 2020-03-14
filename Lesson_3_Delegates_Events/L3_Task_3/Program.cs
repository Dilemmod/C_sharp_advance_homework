using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3_Task_3
{
    delegate int Anonim(Delegate[] arreyDel);
    delegate int MyDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            MyDelegate myDelOne = () => rand.Next(0, 30);
            MyDelegate myDelTwo = () => rand.Next(0, 30);
            MyDelegate myDelThree = () => rand.Next(0, 30);
            MyDelegate myDelFour = () => rand.Next(0, 30);
            MyDelegate[] myDelArrey = { myDelOne, myDelTwo, myDelThree, myDelFour };
            Anonim anonim = (arreyDelForAnonim) =>
            {
                int res=0;
                for (int i = 0; i < arreyDelForAnonim.Length; i++)
                {
                    MyDelegate del = (MyDelegate)arreyDelForAnonim[i];
                    int temp = del.Invoke();
                    res += temp;
                    Console.WriteLine((i + 1) + " Temp = " + temp);
                    Console.WriteLine((i+1)+" Result = "+res);
                }
                return res/ arreyDelForAnonim.Length;
            };
            Console.WriteLine(anonim.Invoke(myDelArrey));
            Console.ReadKey();
        }
       
    }
}
