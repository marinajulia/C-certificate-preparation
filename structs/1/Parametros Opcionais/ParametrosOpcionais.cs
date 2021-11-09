using System;
using System.Collections.Generic;
using System.Text;

namespace Programming1.Parametros_Opcionais
{
    public class ParametrosOpcionais
    {
        public void Executar()
        {
            ClienteEspecial clienteEspecial= new ClienteEspecial("lucas");
            clienteEspecial.FazerPedido(1, "rua", 1);

            clienteEspecial = new ClienteEspecial("");
            clienteEspecial.FazerPedido(1, "rua", 1);

            clienteEspecial.FazerPedido(2, "Comercial");
        }
    }

    class ClienteEspecial
    {
        private readonly string nome;

        //assume o valor default anonimo de não vier nenhum parâmetro:
        public ClienteEspecial(string nome ="Anonimo")
        {
            this.nome = nome;
        }

        public void FazerPedido(int produtoId, string endereco, int quantidade =32)
        {
            Console.WriteLine($"nome : {nome}, id produto: {produtoId}, endereço: {endereco}, quantidade: {quantidade}");
        }
    }
}
