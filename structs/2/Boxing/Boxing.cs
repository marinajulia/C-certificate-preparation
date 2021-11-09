using System;
using System.Collections.Generic;
using System.Text;

namespace Programming._2.Boxing
{
   public class Boxing
    {
        public void Executar()
        {
            int numero = 57;
            //boxing:
            object caixa = numero;

            //unboxing:
            try
            {
                //conversão explícita:
                int unboxed = (int)caixa;
                Console.WriteLine("ok");
            }
            catch(InvalidCastException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
