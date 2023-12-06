using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastrar_Aluno_forms.Classes
{
    public class Turma
    {
        public string Nome { get; set; }
        public string Materia { get; set; }
        public List<AlunoTurma> AlunosTurmas { get; set; }
        public List<Turma> Turmas { get; set; }

        public Turma(string nome, string materia)
        {
            Nome = nome;
            Materia = materia;
            AlunosTurmas = new List<AlunoTurma>();
            Turmas = new List<Turma>();
        }

        public void AdicionarAluno(string aluno, string turma)
        {
            AlunoTurma alunoTurma = new AlunoTurma(aluno, turma);
            AlunosTurmas.Add(alunoTurma);
        }

        public void RemoverAluno(string aluno)
        {
            AlunoTurma alunoTurma = AlunosTurmas.Find(at => at.Aluno == aluno);

            if (alunoTurma != null)
            {
                AlunosTurmas.Remove(alunoTurma);
            }
        }

        public void OrdenarAlunosPorNome()
        {
       //     AlunosTurmas.Sort((at1, at2) => at1.Aluno.Nome.CompareTo(at2.Aluno.Nome));
        }

        public void OrdenarAlunosPorNotaFinal()
        {
         //   AlunosTurmas.Sort((at1, at2) => at2.CalcularNotaFinal().CompareTo(at1.CalcularNotaFinal()));
        }



        public void AdicionarTurma(Turma turma)
        {
            Turmas.Add(turma);
        }

        public void SalvarInformacoesTurma()
        {

            try
            {
                using (StreamWriter writer = new StreamWriter("informacoes.txt", append: true))
                {
                    foreach (Turma turma in Turmas)
                    {
                        writer.WriteLine($"turma,{turma.Nome},{turma.Materia}");

                    }
                }


            }
            catch (Exception)
            {
                //  Console.WriteLine($"Erro ao salvar o arquivo: {ex.Message}");

            }
        }
    }
}
