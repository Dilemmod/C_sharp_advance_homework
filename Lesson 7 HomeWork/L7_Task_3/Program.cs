using System;
using System.IO;
using System.IO.Compression;

namespace L7_Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите файл которий нужно найти: ");
            //string fileName = "RandomText.txt";
            string fileName = Console.ReadLine();
            string[] filesTXT = Directory.GetFiles(@".", fileName, SearchOption.AllDirectories);

            if (directory.Exists)
            {
                if (filesTXT.Length == 1)
                {
                    Console.WriteLine("\nФайл найден\n");
                    FileStream fileStream = filesTXT[0].OpenRead();
                    // преобразуем строку в байты
                    byte[] array = new byte[fileStream.Length];
                    // считываем данные
                    fileStream.Read(array, 0, array.Length);
                    // декодируем байты в строку
                    string textFromFile = System.Text.Encoding.Default.GetString(array);
                    Console.WriteLine($"\nТекст из файла:\n {textFromFile}");
                    Console.WriteLine(new string('-',20));


                    Console.WriteLine("\tСжать файл?\n Нажмите Y чтобы сжать ");
                    ConsoleKeyInfo nav = Console.ReadKey();
                    if (nav.Key == ConsoleKey.Y)
                    {
                        try
                        {
                            FileStream destination = File.Create(@$"{path}\archive.zip");
                            GZipStream compressor = new GZipStream(destination, CompressionMode.Compress);
                            int theByte = fileStream.ReadByte();

                            while (theByte != -1)
                            {
                                compressor.WriteByte((byte)theByte);
                                theByte = fileStream.ReadByte();
                            }
                            compressor.Close();
                            Console.WriteLine("\nФайл успешно заархивирован");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }

                    }

                }
                else
                {
                    Console.WriteLine("\nФайла с именем: {0}  не существует.", fileName);
                }
            }
            else
            {
                Console.WriteLine("\nДиректории с именем: {0}  не существует.", directory.Name);
            }
            Console.ReadKey();

        }
    }
}
