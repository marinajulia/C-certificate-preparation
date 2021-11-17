using System;
using System.Collections.Generic;
using System.Text;

namespace Programming._3.equals
{
   public class Equals
    {
        public void Executar()
        {
            Aluno aluno1 = new Aluno()
            {
                Nome = "josé",
                DataNascimento = new DateTime(1999, 1, 1)
            };
            Aluno aluno2 = new Aluno()
            {
                Nome = "josé",
                DataNascimento = new DateTime(1995, 1, 1)
            };
            Aluno aluno3 = new Aluno()
            {
                Nome = "José",
                DataNascimento = new DateTime(1999, 1, 1)
            };

            Console.WriteLine(aluno1.Equals(aluno2));
            Console.WriteLine(aluno1.Equals(aluno3));

            Aluno aluno4 = new Aluno()
            {
                Nome = "andré",
                DataNascimento = new DateTime(1970, 1, 1)
            };

            Aluno aluno5 = new Aluno()
            {
                Nome = "Ana",
                DataNascimento = new DateTime(1990, 1, 1)
            };

            List<Aluno> alunos = new List<Aluno>();
            alunos.Add(aluno1);
            alunos.Add(aluno2);
            alunos.Add(aluno3);
            alunos.Add(aluno4);
            alunos.Add(aluno5);

            //para fazer a ordenação:
            alunos.Sort();

            foreach(var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
        }
    }

    class Aluno : IComparable
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public override string ToString()
        {
            return $"nome: {Nome}, data de nascimento: {DataNascimento:dd/MM/yyyy} ";
        }
        public override bool Equals(object obj)
        {
            Aluno outro = obj as Aluno;
            if (outro == null)
                return false;

            return this.Nome.Equals(outro.Nome, StringComparison.CurrentCultureIgnoreCase) 
                && this.DataNascimento.Equals(outro.DataNascimento);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Nome, DataNascimento);
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
                return 1;

            Aluno outro = obj as Aluno;
            if (outro == null)
                throw new ArgumentException("não é um aluno");

            var resultado = this.DataNascimento.CompareTo(outro.DataNascimento);
            if (resultado == 0)
                resultado = this.Nome.CompareTo(outro.Nome);

            return resultado;
        }
    }
}
