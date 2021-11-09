using System;
using System.Collections.Generic;
using System.Text;

namespace Programming1.Tipos_de_Referencia
{
    public class TiposDeReferencia
    {
        public void Executar()
        {
            var cliente1 = new Cliente("José da Silva", 42);
            var cliente2 = cliente1;

            Console.WriteLine("José:");
            Console.WriteLine($"Cliente1: {cliente1}");
            Console.WriteLine($"Cliente2: {cliente2}");

            //quando era struct, o nome do cliente2 não se alterava, com a classe se altera
            cliente1.Nome = "Maria de Souza";
            Console.WriteLine();
            Console.WriteLine("Maria:");
            Console.WriteLine($"Cliente1: {cliente1}");
            Console.WriteLine($"Cliente2: {cliente2}");
        }
    }
    
    class Cliente
    {
        public Cliente(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}";
        }
    }
}
