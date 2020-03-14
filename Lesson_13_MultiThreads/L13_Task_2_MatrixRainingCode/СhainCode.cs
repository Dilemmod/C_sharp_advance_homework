using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace L13_Task_2_MatrixRainingCode
{
     class Сolumn
    {
        public int PosX { set; get; }
        public int PosY { set; get; }
        public char Symbol { set; get; }
    }
    class СhainCode
    {
        List<Сolumn> columnList = new List<Сolumn>();
        Random rand = new Random();
        int indent;
        public СhainCode()
        {
            Console.CursorVisible = false;
        }
        public void RunChain(object indent)
        {
            this.indent = (int)indent;
            int chainLength = rand.Next(4,12);
            columnList.Add(new Сolumn() { PosX = (int)indent, PosY = 0 });
            while (columnList.Count > 0)
            {
                ChainOutput();
                //Добавление звена цепочки
                if (chainLength > 0)
                {
                    columnList.Add(new Сolumn() { PosX = (int)indent, PosY = -1});
                    chainLength--;
                }
                for (int i = 0; i < columnList.Count; i++)
                {
                    columnList[i].Symbol = (char)rand.Next(0x41, 0x5a);
                    columnList[i].PosY++;
                }
                //Удаление звена цепочки
                if (columnList[0].PosY==Console.WindowHeight)
                    columnList.RemoveAt(0);
                //Рекурсия
                if (columnList.Count == 0)
                    RunChain(indent);
                //Очистка консоли от остатков
                columnList[columnList.Count - 1].Symbol = (char)(0x20);
            }
        }
        private void ChainOutput()
        {
            //for (int i = 0; i < Console.WindowWidth; i++)
            //{
            //    for (int j = 0; j < indent; j++)
            //    {
            //        Console.Write(space[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            for (int i = 0; i < columnList.Count; i++)
            {   
                Console.SetCursorPosition(indent,columnList[i].PosY);
                Console.ForegroundColor = (i==0? ConsoleColor.White:(i==1? ConsoleColor.Green:ConsoleColor.DarkGreen));
                    Console.Write(columnList[i].Symbol);
            }
            Thread.Sleep(50);
        }
    }
}
