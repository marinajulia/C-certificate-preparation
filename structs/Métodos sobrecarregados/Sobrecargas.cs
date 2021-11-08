using System;
using System.Collections.Generic;
using System.Text;

namespace Programming1.Métodos_sobrecarregados
{
    public class Sobrecargas
    {
        public void Executar()
        {
            int lado = 3;
            Console.WriteLine("Volume do cubo: " + Volume(lado));

            double raio = 2;
            int altura = 10;
            Console.WriteLine("Volume do cilindo " + Volume(altura, raio));

            long largura = 10;
            altura = 6;
            int profundidade = 4;
            Console.WriteLine("Volume do prisma:" + Volume(largura, profundidade, altura));

        }

        double Volume(double lado)
        {
            return Math.Pow(lado, 3);
        }

        double Volume(double altura, double raio)
        {
            return altura * Math.PI * Math.Pow(raio, 2);
        }

        double Volume(long largura, int profundidade, int altura)
        {
            return largura * profundidade * altura;
        }
    }
}
