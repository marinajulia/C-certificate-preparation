using System;
using System.Collections.Generic;
using System.Text;

namespace Programming1.Parametros_Opcionais
{
    public class ParametrosNomeados
    {
        public void Executar()
        {
            //jeito normal:
            ImprimirDetalhesDoPedido("vendedor", 1, "nomeProduto");

            //argumentos nomeados(aceitam parâmetros em qualuqer ordem):
            ImprimirDetalhesDoPedido(numeroPedido: 1, nomeProduto: "nomeProduto", vendedor: "vendedor");

            //argumentos nomeados misturados:
            ImprimirDetalhesDoPedido("vendedor", 1, nomeProduto: "nomeProduto");
        }

        void ImprimirDetalhesDoPedido(string vendedor, int numeroPedido, string nomeProduto)
        {
            if (string.IsNullOrEmpty(vendedor))
                throw new ArgumentException(message: "Nome do vendedor é nulo");

            Console.WriteLine($"Vendedor: {vendedor}, numero do pedido: {numeroPedido} nome do produto: {nomeProduto}");
        }
    }
}
