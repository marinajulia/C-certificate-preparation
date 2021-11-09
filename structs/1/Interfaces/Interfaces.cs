using System;
using System.Collections.Generic;
using System.Text;

namespace Programming1.Interfaces
{
    public class Interfaces
    {
        public void Executar()
        {
            IEletrodomestico eletro1 = new Televisao();
            eletro1.Ligar();
            eletro1 = new Lanterna();
       
        }
    }

    interface IEletrodomestico
    {
        void Ligar();
        void Desligar();
    }

    interface IIluminacao
    {
        double PotenciaDaLampada { get; set; }
    }

    class Televisao : IEletrodomestico, IIluminacao
    {
        public double PotenciaDaLampada { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Desligar()
        {
            Console.WriteLine("desligado");
        }

        public void Ligar()
        {
            Console.WriteLine("ligado");
        }
    }

    class Radio : IEletrodomestico
    {
        public void Desligar()
        {
            Console.WriteLine("desligado");
        }

        public void Ligar()
        {
            Console.WriteLine("ligado");
        }
    }

    class Lanterna : IEletrodomestico, IIluminacao
    {
        public double PotenciaDaLampada { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Desligar()
        {
            Console.WriteLine("desligado");
        }

        public void Ligar()
        {
            Console.WriteLine("ligado");
        }
    }

}
