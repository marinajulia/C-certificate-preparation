using System;
using System.Collections.Generic;
using System.Text;

namespace Programming._3.Encapsulamento
{
    public class Encapsulamento
    {
        decimal salario;
        public decimal Salario
        {
            get
            {
                return salario;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("salario negativo");
                salario = value;
            }
        }
    }
}
