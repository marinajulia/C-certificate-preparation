using Programming1.Metodos_substituidos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Programming._2.Conversoes_implicitas
{
    public class ConversoesImplicitas
    {
        public void Executar()
        {
            int inteiro = 27634354;
            long inteiroLongo = inteiro;

            Gato gato = new Gato();
            Animal animal = gato;
            Console.WriteLine(animal.GetType());
        }
    }
}
