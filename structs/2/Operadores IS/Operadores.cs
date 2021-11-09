using Programming1.Metodos_substituidos;
using Programming1.Tipos_de_Referencia;
using System;
using System.Collections.Generic;
using System.Text;

namespace Programming._2.Conversoes_explicitas
{
   public class Operadores
    {
        public void Executar()
        {
            Animal animal = new Animal();
            Gato gato = new Gato();
            Cliente cliente = new Cliente("josé silva", 30);
        }
        public void Alimentar(object obj)
        {
            Animal animal = (Animal)obj;
            animal.Beber();
            animal.Comer();
        }
    }
}
