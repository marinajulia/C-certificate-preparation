using System;
using System.Collections.Generic;
using System.Text;

namespace Programming1.Dynamic
{
    public class Dynamics
    {
        public void Executar()
        {
            Object objeto = 1;
            //Dá erro:
            //objeto = objeto + 2;

            dynamic dinamico = 1;
            dinamico = dinamico + 2;
            Console.WriteLine(dinamico);
        }
    }
}
