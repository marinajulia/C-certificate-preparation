using System;
using System.Collections.Generic;
using System.Text;

namespace Programming1.Delegate
{
    public class Delegates
    {
        public void Executar()
        {
            Calculadora.Executar();
        }
    }

    delegate double MetodoMultiplicacao(double input);

    class Calculadora
    {
        static double Duplicar(double input)
        {
            return input * 2;
        }
        static double Triplicar(double input)
        {
            return input * 3;
        }
        public static void Executar()
        {
            //metodo comum:
            Console.WriteLine(Triplicar(7.5));

            //delegate:
            MetodoMultiplicacao metodoMultiplicacao = Duplicar;
            Console.WriteLine(metodoMultiplicacao(7.5));

            metodoMultiplicacao = Triplicar;
            Console.WriteLine(metodoMultiplicacao(7.5));
        }
    }
}
