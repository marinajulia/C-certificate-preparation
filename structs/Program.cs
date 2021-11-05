using Programming1.Classe;
using Programming1.Delegate;
using Programming1.Dynamic;
using Programming1.Enums;
using Programming1.Interfaces;
using Programming1.Objetos;
using Programming1.Parametros_Opcionais;
using Programming1.Strings;
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
            Objetos objetos = new Objetos();
            Dynamics dynamic = new Dynamics();
            Strings strings = new Strings();
            ParametrosNomeados parametrosNomeados= new ParametrosNomeados();
            //str.Executar();
            //enu.Executar();
            //tipos.Executar();
            //classes.Executar();
            //interfaces.Executar();
            //delegates.Executar();
            //objetos.Executar();
            //dynamic.Executar();
            //strings.Executar();
            parametrosNomeados.Executar();
        }
    }
}
