using System;
using System.Collections.Generic;
using System.Text;

namespace Programming1.Propriedades_Indexadas
{
    public class PropriedadesIndexadas
    {
        public void Executar()
        {
            var sala = new Sala();
            sala["D01"] = new ClienteCinema("Maria");
            sala["D02"] = new ClienteCinema("José");
            sala.ImprimirReservas();
        }
    }

    class Sala
    {
        private readonly IDictionary<string, ClienteCinema> reservas
             = new Dictionary<string, ClienteCinema>();

        public ClienteCinema this[string codigoAssento]
        {
            get
            {
                return reservas[codigoAssento];
            }
            set
            {
                reservas[codigoAssento] = value;
            }
        }

        public void ImprimirReservas()
        {
            foreach(var reserva in reservas)
            {
                Console.WriteLine($"{reserva.Key} = {reserva.Value}");
            }
        }
    }

    class ClienteCinema
    {
        public ClienteCinema(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
