using System;
using System.Collections.Generic;
using System.Text;

namespace Programming._3.Encapsulamento
{
    public class Encapsulamento
    {
        public Encapsulamento(decimal salario)
        {
            if (salario < 0)
                throw new ArgumentOutOfRangeException("salario negativo");
            this.salario = salario;
        }
        decimal salario;
        public decimal Salario
        {
            get
            {
                return salario;
            }
            //para ficar de somente leitura:
            //set
            //{
            //    if (value < 0)
            //        throw new ArgumentOutOfRangeException("salario negativo");
            //    salario = value;
            //}
        }

        //usando propfull tabtab
        //private int myVar;

        //public int MyProperty
        //{
        //    get { return myVar; }
        //    set { myVar = value; }
        //}

        //auto implementada:
        //public decimal Salario { get; set; }
    }
}
