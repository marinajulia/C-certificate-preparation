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

            Alimentar(animal);
            Alimentar(gato);
            Alimentar(cliente);
        }
        public void Alimentar(object obj)
        {
            ////is para tipo ou interface
            //if (obj is Animal)
            //    animal = (Animal)obj;


            //outro jeito: 

            ////o as tenta fazer uma conversão, se não conseguir, o valor ficará nulo, não vai estourar uma exception
            //Animal animal = obj as Animal;


            //outro jeito:

            if (obj is Animal animal)
            {
                animal.Beber();
                animal.Comer();
                return;
            }
            Console.WriteLine("Obj não é um animal");
        }
    }
}
