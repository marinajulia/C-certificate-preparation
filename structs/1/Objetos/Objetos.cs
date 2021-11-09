using System;
using System.Collections.Generic;
using System.Text;

namespace Programming1.Objetos
{
    public class Objetos
    {
        public void Executar()
        {
            Jogador meuObjeto = new Jogador();

            //maneira que o curso faz:
            //Object meuObjeto;
            //Jogador classRef;
            //classRef = (Jogador)meuObjeto; //conversão explicita ou cast

            Console.WriteLine(meuObjeto.Pontuacao);
        }
    }

    class Jogador
    {
        public int Pontuacao { get; set; } = 10;
    }
}
