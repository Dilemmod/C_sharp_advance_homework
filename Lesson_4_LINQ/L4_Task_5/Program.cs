using System;
using System.Collections.Generic;

namespace L4_Task_5
{
    class Program
    {
        static void Main(string[] args)
        {

            dynamic words = new[]
            {
                new{wordRus= "отобразить", wordEng= "display"},
                new{wordRus= "ограничение", wordEng= "restriction"},
                new{wordRus= "курьер", wordEng= "carrier"},
                new{wordRus= "лопасть", wordEng= "blades"},
                new{wordRus= "задний", wordEng= "rear"},
                new{wordRus= "избыточность", wordEng= "redundancy"},
                new{wordRus= "отсек", wordEng= "compartment"},
                new{wordRus= "упругость", wordEng= "resilience"},
                new{wordRus= "отключение питания", wordEng= "power cut"},
                new{wordRus= "затопление", wordEng= "flooding"}

            };
            foreach (var w in words)
            {
                Console.Write("word in Russian: "+w.wordRus+ "\n     in English: " + w.wordEng+"\n\n");
            }
            Console.Read();
        }
    }
}
