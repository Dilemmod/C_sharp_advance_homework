using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using L6_Task_1;

namespace L6_Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Assembly assembly = null;

            try
            {
                // Assembly.Load() - метод для загрузки сборки.
                assembly = Assembly.Load("L6_Task_1"); // LoadFrom(...)
                Console.WriteLine("Сборка TemperatureСonverter - успешно загружена.");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Получения информации о всех типах в сборке.
            GetInfoAboutAllTypes(assembly);

            // Получения информации о членах класса.
            GetInfoAboutAllMembers(assembly);

            // Получения информации о параметрах для метода.
            GetMethodsParams(assembly);

            //Задержка
            Console.ReadKey();
        }

        #region GetInfoAboutAllTypes - Получения информации о всех типах в сборке.
        /// <summary>
        /// Получения информации о всех типах в сборке.
        /// </summary>
        public static void GetInfoAboutAllTypes(Assembly assembly)
        {
            Console.WriteLine(new string('+', 40));
            Console.WriteLine("\nТипы в: {0} \n", assembly.FullName);

            Type[] types = assembly.GetTypes();

            foreach (Type type in types)
            {
                Console.WriteLine("Полное Имя:             {0}", type.FullName);
                Console.WriteLine("Это class:              {0}", type.IsClass);
            }
        }
        #endregion

        #region GetInfoAboutAllMembers - Получения информации о членах класса.
        /// <summary>
        /// Получения информации о членах класса.
        /// </summary>
        public static void GetInfoAboutAllMembers(Assembly assembly)
        {
            Console.WriteLine(new string('+', 40));

            Type type = assembly.GetType("L6_Task_1.TemperatureСonverter");

            Console.WriteLine("\nЧлены класса: {0} \n", type.Name);

            MemberInfo[] membersInfo = type.GetMembers();

            foreach (MemberInfo memberInfo in membersInfo)
            {
                Console.WriteLine("{0,-15}:  {1}", memberInfo.MemberType, memberInfo);
            }
        }
        #endregion

        #region GetMethodsParams - Получения информации о  о параметрах для метода.
        /// <summary>
        /// Получения информации о  о параметрах для метода.
        /// </summary>
        public static void GetMethodsParams(Assembly assembly)
        {
            Console.WriteLine(new string('+', 40));
            Type type = assembly.GetType("L6_Task_1.TemperatureСonverter");

            MethodInfo method = type.GetMethod("ConvertCelsiusToFahrenheit");

            // Вывод информации о количестве параметров.
            Console.WriteLine("\nИнформация о параметрах для метода {0}", method.Name);

            ParameterInfo[] parameters = method.GetParameters();
            Console.WriteLine("Метод имеет " + parameters.Length + " параметров");

            // Выводим некоторые характеристики каждого из параметров. 
            foreach (ParameterInfo parameter in parameters)
            {
                Console.WriteLine("Имя параметра: {0}", parameter.Name);
                Console.WriteLine("Позиция в методе: {0}", parameter.Position);
                Console.WriteLine("Тип параметра: {0}", parameter.ParameterType);
            }
        }
        #endregion
    }
}

