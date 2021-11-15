using Programming._2.Boxing;
using Programming._2.Conversões_com_classes_auxiliares;
using Programming._2.Conversoes_explicitas;
using Programming._2.Conversoes_implicitas;
using Programming._2.Interoperabilidade_COM;
using Programming._2.Operadores_de_conversão;
using Programming._2.Resolucao_de_Sobrecarga;
using Programming._2.string__var__dinamic;
using Programming._2.string__var__dynamic.Conversoes_entre_dynamic;
using Programming._3.Encapsulamento;
using Programming._3.equals;
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
            ParametrosOpcionais parametrosOpcionais = new ParametrosOpcionais();
            MetodosDeExtensao metodosDeExtensao = new MetodosDeExtensao();
            PropriedadesIndexadas propriedadesIndexadas = new PropriedadesIndexadas();
            Sobrecargas sobrecargas = new Sobrecargas();
            MetodosSubstituidos metodosSubstituidos = new MetodosSubstituidos();
            Boxing boxing = new Boxing();
            ConversoesImplicitas conversoesImplicitas = new ConversoesImplicitas();
            ConversoesExplicitas conversoesExplicitas = new ConversoesExplicitas();
            Operadores operadores = new Operadores();
            OperadoresDeConversao operadoresDeConversao = new OperadoresDeConversao();
            MetodosAuxiliares metodosAuxiliares = new MetodosAuxiliares();
            UsandoDynamic usandoDynamic = new UsandoDynamic();
            ConversoesDeDynamic conversoesDeDynamic = new ConversoesDeDynamic();
            ResolucaoDeSobrecarga resolucaoDeSobrecarga = new ResolucaoDeSobrecarga();
            UsandoExpandObject usandoExpandObject = new UsandoExpandObject();
            InteropCOM interopCOM = new InteropCOM();
            Encapsulamento funcionario = new Encapsulamento(1000);
            Equals equals = new Equals();
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
            //metodosSubstituidos.Executar();
            //boxing.Executar();
            //conversoesImplicitas.Executar();
            //conversoesExplicitas.Executar();
            //operadores.Executar();
            //operadoresDeConversao.Executar();
            //metodosAuxiliares.Executar();
            //usandoDynamic.Executar();
            //conversoesDeDynamic.Executar();
            //resolucaoDeSobrecarga.Executar();
            //usandoExpandObject.Executar();
            //interopCOM.Executar();
            equals.Executar();


            //funcionario.Salario = -1200;
            //Console.WriteLine(funcionario.Salario);
            //funcionario.Salario = 1200;
            //Console.WriteLine(funcionario.Salario);

        }
    }
}
