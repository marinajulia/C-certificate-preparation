using Programming1.Classe;
using Programming1.Delegate;
using Programming1.Enums;
using Programming1.Interfaces;
using Programming1.Tipos_de_Referencia;
using System;

namespace structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Structs str = new Structs();
            Enums enu = new Enums();
            TiposDeReferencia tipos = new TiposDeReferencia();
            Classes classes = new Classes();
            Interfaces interfaces = new Interfaces();
            Delegates delegates = new Delegates();
            //str.Executar();
            //enu.Executar();
            //tipos.Executar();
            //classes.Executar();
            //interfaces.Executar();
            delegates.Executar();
        }
    }
}
