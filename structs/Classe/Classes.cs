using structs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Programming1.Classe
{
    public class Classes
    {
        public void Executar()
        {
            ClassePosicaoGps posicao1 = new ClassePosicaoGps()
            {
                Latitude = 12,
                Longitude = 15
            };
            posicao1 = new ClassePosicaoGps(13.78, 29.51);

            Console.WriteLine(posicao1);

            PosicaoGpsComLeitura posicao2 = new PosicaoGpsComLeitura(12, 15, DateTime.Now);
            Console.WriteLine(posicao2);
        }
    }
    class ClassePosicaoGps : IGPS
    {
        public double Latitude;
        public double Longitude;

        public ClassePosicaoGps()
        {

        }

        public ClassePosicaoGps(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public bool EstaNoHemisferioNorte()
        {
            return Latitude > 0;
        }

        public override string ToString()
        {
            return $"Latitude:{Latitude}, Longitude:{Longitude}";
        }
    }

    class PosicaoGpsComLeitura : ClassePosicaoGps
    {
        private readonly DateTime dataLeitura;

        public PosicaoGpsComLeitura(double latitude, double longitude, DateTime dataLeitura)
            : base(latitude, longitude)
        {
            this.dataLeitura = dataLeitura;
        }

        public override string ToString()
        {
            return $"Latitude:{Latitude}, Longitude:{Longitude}, Data da leitura: {dataLeitura}";
        }
    }
}


