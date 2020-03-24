using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace L13_Task_2_MatrixRainingCode
{
    class СhainCode
    {
        Random rand;
        int column;
        static readonly object locker = new object();
        public СhainCode(int column)
        {
            Console.CursorVisible = false;
            this.column = column;
            rand = new Random((int)DateTime.Now.Ticks);
        }
        public void RunChain()
        {
            int length;
            int count;

            while (true)
            {
                count = rand.Next(6, 12);
                length = 0;

                Thread.Sleep(rand.Next(10, 4000));

                for (int i = 0; i < Console.WindowHeight-1; i++)
                {
                    lock (locker)
                    {
                        if (length == count)
                            count = 0;
                        else if (length < count)
                            length++;
                        else if ((Console.WindowHeight - 2) - i < length)
                            length--;
                        Console.CursorTop = i;
                        ChainOutput(length);
                        Thread.Sleep(1);
                    }
                }
            }
        }
        private void ChainOutput(int length)
        {
            for (int j = 0; j < length + 1; j++)
            {
                Console.CursorLeft = column;
                Console.ForegroundColor = (j == length ? ConsoleColor.White : (j == length - 1 ? ConsoleColor.Green : ConsoleColor.DarkGreen));
                //Очистка консоли от остатков
                if (j == 0)
                    Console.WriteLine(" ");
                else
                {
                    int choice = rand.Next(0, 3);
                    Console.WriteLine(choice==0?(char)rand.Next('#', '&'):(choice==1? (char)rand.Next('0', '9'): (char)rand.Next('A', 'Z')));
                }
            }
        }
    }
}
