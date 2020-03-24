using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace L13_Task_2_MatrixRainingCode
{
    class Program
    {
        //Full screen
        [DllImport("user32.dll")]
        public static extern bool ShowWindow(System.IntPtr hWnd, int cmdShow);
        static void Main()
        {
            //Размер окна
            Process p = Process.GetCurrentProcess();
            ShowWindow(p.MainWindowHandle, 3);
            Console.BufferHeight = Console.WindowHeight;


            СhainCode instance;

            for (int i = 0; i < 34; i++)
            {
                instance = new СhainCode(i * 7);
                new Thread(instance.RunChain).Start();
            }

            Console.ReadKey();
        }
    }
}
