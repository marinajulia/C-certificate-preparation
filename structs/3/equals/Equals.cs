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
        }
    }

    class Aluno
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
    }
}
