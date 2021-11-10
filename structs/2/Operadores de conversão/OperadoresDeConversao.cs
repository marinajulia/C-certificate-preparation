using System;
using System.Collections.Generic;
using System.Text;

namespace Programming._2.Operadores_de_conversão
{
    public class OperadoresDeConversao
    {
        public void Executar()
        {
            AnguloEmGraus anguloEmGraus = 45;
            Console.WriteLine(anguloEmGraus);

            AnguloEmRadianos anguloEmRadianos = 15;
            Console.WriteLine(anguloEmRadianos);

            double graus = anguloEmGraus;

            //como o método foi declarado como explicit, é nessessario colocar o tipo explicitamente
            anguloEmRadianos = (AnguloEmRadianos)anguloEmGraus;
            anguloEmGraus = anguloEmRadianos;
            Console.WriteLine($"anguloEmGraus: {anguloEmGraus}");
            Console.WriteLine($"anguloEmRadianos: {anguloEmRadianos}");
        }
    }
    public struct AnguloEmRadianos
    {
        public double Radianos { get; }

        public AnguloEmRadianos(double radianos)
        {
            this.Radianos = radianos;
        }

        public static explicit operator AnguloEmRadianos(AnguloEmGraus graus)
        {
            return new AnguloEmRadianos(graus.Graus * Math.PI / 180);
        }

        public static implicit operator AnguloEmRadianos(double radianos)
        {
            return new AnguloEmRadianos(radianos);
        }

        public static implicit operator double (AnguloEmRadianos radianos)
        {
            return radianos.Radianos;
        }

        public override string ToString()
        {
            return String.Format("{0} radianos", this.Radianos);
        }
    }

    public struct AnguloEmGraus
    {
        public double Graus { get; }

        public AnguloEmGraus(double graus) { this.Graus = graus; }

        public static implicit operator AnguloEmGraus(AnguloEmRadianos radianos)
        {
            return new AnguloEmGraus(radianos.Radianos * 180 / System.Math.PI);
        }

        public static implicit operator AnguloEmGraus(double graus)
        {
            return new AnguloEmGraus(graus);
        }

        public static implicit operator double(AnguloEmGraus graus)
        {
            return graus.Graus;
        }

        public override string ToString()
        {
            return String.Format("{0} graus", this.Graus);
        }
    }
}
