using System;
using System.Collections.Generic;
using System.Text;

namespace Programming.Manipulação_de_string
{
    public class StringBuild
    {
        public void Executar()
        {
            StringBuilder materias = new StringBuilder(); //empty significa string vazia

            materias.Append("português");
            Console.WriteLine(materias);

            materias.Append("matematica");
            Console.WriteLine(materias);

            materias.Append("geografia");
            Console.WriteLine(materias);

            Console.ReadKey();
        }
    }
}
