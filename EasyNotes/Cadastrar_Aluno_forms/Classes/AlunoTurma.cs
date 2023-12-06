using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastrar_Aluno_forms.Classes
{
    public class AlunoTurma
    {
        public string Aluno { get; set; }
        public string Turma { get; set; }

        public AlunoTurma(string aluno, string turma)
        {
            Aluno = aluno;
            Turma = turma;
        }

    }
}
