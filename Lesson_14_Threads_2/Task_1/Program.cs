using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double,double,double,string> funcCalc = new Func<double, double, double, string>(CalculatoTriangleAngles   );

            funcCalc.BeginInvoke(5, 6, 9, CallBack, "Градус первого угла {0} \nГрадус второго угла {1} \nГрадус третьего угла {2}");

            Console.ReadKey();
        }
        static string CalculatoTriangleAngles(double a, double b, double c)
        {
            double A = Math.Acos((Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2)) / (2 * a * c));
            double B = Math.Acos((Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(c, 2)) / (2 * a * b));
            double C = Math.Acos((Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) / (2 * b * c));
            string resultRadian = $"{A} {B} {C}";
            return resultRadian;
        }
        static void CallBack(IAsyncResult asyncResult)
        {
            Func<double, double, double, string> caller = (Func<double, double, double, string>)(asyncResult as AsyncResult).AsyncDelegate;

            // Получение результатов асинхронной операции.
            string resultRadian = caller.EndInvoke(asyncResult);
            //Отделение разных углов
            string[] anglesRad = resultRadian.Split(' ');
            //Переобразование радиан в градусы
            Func<double, double> transferRadToGrad = (d) =>d*(180/Math.PI);
            
            string result = string.Format(asyncResult.AsyncState.ToString(), transferRadToGrad(Convert.ToDouble(anglesRad[0])), transferRadToGrad(Convert.ToDouble(anglesRad[1])), transferRadToGrad(Convert.ToDouble(anglesRad[2])) );
            Console.WriteLine("Результат: \n" + result);
        }
    }
}
