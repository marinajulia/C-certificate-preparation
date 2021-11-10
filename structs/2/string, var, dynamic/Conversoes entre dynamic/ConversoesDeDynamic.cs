using System;
using System.Collections.Generic;

namespace Programming._2.string__var__dynamic.Conversoes_entre_dynamic
{
    public class ConversoesDeDynamic
    {
        public void Executar()
        {
            dynamic d1 = 7;
            dynamic d2 = "string";
            dynamic d3 = DateTime.Now;
            dynamic d4 = new List<int>() { 123, 345, 321 };

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
        }

    }
}
