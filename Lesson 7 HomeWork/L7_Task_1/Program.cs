using System;
using System.IO;

namespace L7_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 50; i++)
            {
                DirectoryInfo folder = new DirectoryInfo(@$"Folder_{i}");
                folder.Create();
                if (folder.Exists)
                {
                    Console.WriteLine("FullName      : {0}", folder.FullName);
                    Console.WriteLine("Name          : {0}", folder.Name);
                    Console.WriteLine("Parent        : {0}", folder.Parent);
                    Console.WriteLine("CreationTime  : {0}", folder.CreationTime);
                    Console.WriteLine("Attributes    : {0}", folder.Attributes.ToString());
                    Console.WriteLine("Root          : {0}", folder.Root);
                    Console.WriteLine("LastAccessTime: {0}", folder.LastAccessTime);
                    Console.WriteLine("LastWriteTime : {0}", folder.LastWriteTime);
                    Console.WriteLine(new string('-',40));
                }
                else
                {
                    Console.WriteLine("Директория с именем: {0}  не существует.", folder.FullName);
                }
            }
            Console.WriteLine("Нажмите любую клавишу для удаления директорий.");
            Console.ReadKey();
            for (int i = 0; i <= 50; i++)
            {
                DirectoryInfo folder = new DirectoryInfo(@$"Folder_{i}");
                folder.Delete();
            }
            Console.WriteLine("Папки успешно удалены.");
        }
    }
}
