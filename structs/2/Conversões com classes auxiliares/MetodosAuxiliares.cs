using System;
using System.Collections.Generic;
using System.Text;

namespace Programming._2.Conversões_com_classes_auxiliares
{
    public class MetodosAuxiliares
    {
        public void Executar()
        {
            string textoDigitado = "123";
            int numeroConvertido = int.Parse(textoDigitado);

            Console.WriteLine(numeroConvertido);

            textoDigitado = "abc";
            //tryParse tenta converter sem gerar exception
            if (int.TryParse(textoDigitado, out numeroConvertido))
            {
                Console.WriteLine(numeroConvertido);
            }
            else
            {
                Console.WriteLine("isso não é um número");
            }

            //tryparse comum não aceita o ponto e imprime 12365
            textoDigitado = "R$ 123.65";
            decimal.TryParse(textoDigitado, System.Globalization.NumberStyles.Currency, //moeda
                System.Globalization.CultureInfo.CurrentCulture, //pt-br
                out decimal valorConvertido);

            Console.WriteLine(valorConvertido);
        }
    }
}
