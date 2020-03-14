using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace L13_Task_2_MatrixRainingCode
{
    class Program
    {
        static void Main()
        {
            Random rand = new Random();
            int indent = 0;
            //Console.BufferWidth = 1000;
            Console.SetBufferSize(1000, 1000);
           // Console.WindowWidth = 999;
            while (indent<Console.WindowWidth)
            {
                СhainCode chainThread = new СhainCode();
                //chainThread.RunChain(0);
                Thread thread = new Thread(chainThread.RunChain);
                thread.Start(indent);
                indent++;
            }

            Console.ReadKey();
        }

    }
}
