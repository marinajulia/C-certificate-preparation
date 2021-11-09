using Programming1.Metodos_substituidos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Programming._2.Conversoes_explicitas
{
    public class ConversoesExplicitas
    {
        public void Executar()
        {
            double salario = 1334.12;
            long copiaSalario = (long)salario;
            Console.WriteLine(copiaSalario);

            Animal animal = new Gato();
            Gato gato = (Gato)animal; //cast - conversão explícita

            Console.WriteLine(gato.GetType());
        }
    }
}
