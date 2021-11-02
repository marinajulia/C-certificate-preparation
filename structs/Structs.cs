using System;
using System.Collections.Generic;
using System.Text;

namespace structs
{
    public class Structs
    {
        public void structs()
        {
            PosicaoGps posicao1;
            posicao1.Latitude = 13.78;
            posicao1.Longitude = 13.78;

            //ou:(sem o construtor)
            PosicaoGps posicao2 = new PosicaoGps()
            {
                Latitude = 12,
                Longitude = 15
            };

            //Com o construtor:
            PosicaoGps posicao3 = new PosicaoGps(80, 5);

            //O ovverride permite imprimir o objeto da maneira que quiser:
            Console.WriteLine(posicao3);
        }
    }
    interface IGPS
    {
        bool EstaNoHemisferioNorte();
    }

    struct PosicaoGps : IGPS
    {
        public double Latitude;
        public double Longitude;

        public PosicaoGps(double latitude, double longitude)
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
}
