using Programming1.Classe;
using Programming1.Delegate;
using Programming1.Dynamic;
using Programming1.Enums;
using Programming1.Interfaces;
using Programming1.Metodos_de_extensao;
using Programming1.Métodos_sobrecarregados;
using Programming1.Metodos_substituidos;
using Programming1.Objetos;
using Programming1.Parametros_Opcionais;
using Programming1.Propriedades_Indexadas;
using Programming1.Strings;
using Programming1.Tipos_de_Referencia;

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
            ParametrosOpcionais parametrosOpcionais = new ParametrosOpcionais();
            MetodosDeExtensao metodosDeExtensao = new MetodosDeExtensao();
            PropriedadesIndexadas propriedadesIndexadas = new PropriedadesIndexadas();
            Sobrecargas sobrecargas = new Sobrecargas();
            MetodosSubstituidos metodosSubstituidos = new MetodosSubstituidos();
            //str.Executar();
            //enu.Executar();
            //tipos.Executar();
            //classes.Executar();
            //interfaces.Executar();
            //delegates.Executar();
            //objetos.Executar();
            //dynamic.Executar();
            //strings.Executar();
            //parametrosNomeados.Executar();
            //parametrosOpcionais.Executar();
            //metodosDeExtensao.Executar();
            //propriedadesIndexadas.Executar();
            //sobrecargas.Executar();
            metodosSubstituidos.Executar();
        }
    }
}
