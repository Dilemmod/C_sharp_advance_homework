using System;
using System.IO;

namespace L7_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            var file = new FileInfo("RandomText.txt");

            StreamWriter writer = file.CreateText();

            writer.WriteLine("Первая строка текста...\nВторая строка...");
            writer.WriteLine("Третья строка...");
            writer.Write("\n\tЧетвёртая строка с отступом...\n\nСлучайные буловые числа");
            for (int i = 0; i <= 20; i++)
            {
                writer.Write(" "+rand.Next(0,2));
            }
            writer.Close();

            Console.WriteLine("Файл RandomText.txt создан и в него записан текст.\nДля просмотра содержимого RandomText.txt нажмите любую клавишу");
            Console.ReadLine();



            Console.WriteLine("Содержимое файла RandomText.txt:\n");

            StreamReader reader = File.OpenText(file.ToString());
            string input;

            while ((input = reader.ReadLine()) != null)
            {
                Console.WriteLine(input);
            }
            reader.Close();
            Console.WriteLine("\nНажмите любую клавишу для удаления директорий.");
            Console.ReadKey();

            file.Delete();

        }
    }
}
