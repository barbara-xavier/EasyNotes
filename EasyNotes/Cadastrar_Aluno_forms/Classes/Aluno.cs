using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastrar_Aluno_forms.Classes
{
     public class Aluno
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CPF { get; set; }
        public string Sexo { get; set; }
        public string Telefone { get; set; }
        public string Matricula { get; set; }

        static List<Aluno> alunos = new List<Aluno>();

        public Aluno(string nome, DateTime dataNascimento, string cpf, string sexo, string telefone, string matricula)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            CPF = cpf;
            Sexo = sexo;
            Telefone = telefone;
            Matricula = matricula;
        }
        public void AdicionarAluno(Aluno aluno)
        {
            alunos.Add(aluno);
        }

        
    
     }
}
