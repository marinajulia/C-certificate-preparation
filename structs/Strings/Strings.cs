using System;
using System.Collections.Generic;
using System.Text;

namespace Programming1.Strings
{
    public class Strings
    {
        public void Executar()
        {
            string a = "ab";
            string b = "a";

            b = b + "b";

            Console.WriteLine($"É igual: {a == b}");
            Console.WriteLine($"Aponta para o mesmo local na memória: {(object)a == (object)b}");

            string bomDia = "bom dia";
            Console.WriteLine($"bom dia[4]{bomDia[4]}");

            var caracter = bomDia[4];
            Console.WriteLine($"tipo do caracter: {caracter.GetType()}");

        }
    }
}
