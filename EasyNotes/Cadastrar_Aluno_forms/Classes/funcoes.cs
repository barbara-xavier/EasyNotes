using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastrar_Aluno_forms.Classes
{
    static class funcoes
    {
        public static List<Aluno> alunos = new List<Aluno>();
        public static List<Turma> turmas = new List<Turma>();
        public static List<AlunoTurma> alunoTurmas = new List<AlunoTurma>();
        public static List<AlunoNota> alunoNotas = new List<AlunoNota>();


        public static void SalvarInformacoes(Aluno aluno)
        {

            try
            {
                using (StreamWriter writer = new StreamWriter("informacoes.txt", append: true))
                {
                    
                  writer.WriteLine($"aluno;{aluno.Nome};{aluno.DataNascimento};{aluno.CPF};{aluno.Sexo};{aluno.Telefone};{aluno.Matricula.PadLeft(2,'0')}");

                    
                }


            }
            catch (Exception)
            {
                //  Console.WriteLine($"Erro ao salvar o arquivo: {ex.Message}");

            }
        }

        public static void SalvarInformacoes(AlunoNota nota)
        {

            try
            {
                using (StreamWriter writer = new StreamWriter("informacoes.txt", append: true))
                {

                    writer.WriteLine($"alunonota;{nota.Aluno};{nota.Atv1.ToString("0.00")};{nota.Atv2.ToString("0.00")};{nota.Trabalho.ToString("0.00")};{nota.Prova1.ToString("0.00")};{nota.Prova2.ToString("0.00")};{nota.Turma}");

                    MessageBox.Show("As notas foram lançadas");
                }


            }
            catch (Exception)
            {
                //  Console.WriteLine($"Erro ao salvar o arquivo: {ex.Message}");

            }
        }

        public static void SalvarInformacoes(AlunoTurma turma)
        {

            try
            {
                using (StreamWriter writer = new StreamWriter("informacoes.txt", append: true))
                {

                    writer.WriteLine($"alunoturma;{turma.Turma};{turma.Aluno}");

                    MessageBox.Show("O aluno foi adicionado na turma");
                }


            }
            catch (Exception)
            {
                //  Console.WriteLine($"Erro ao salvar o arquivo: {ex.Message}");

            }
        }


        public static class InputBox
        {
            public static string Show(string prompt, string title)
            {
                Form form = new Form();
                Label label = new Label();
                TextBox textBox = new TextBox();
                Button buttonOk = new Button();

                form.Text = title;
                label.Text = prompt;
                buttonOk.Text = "OK";
                buttonOk.DialogResult = DialogResult.OK;

                label.SetBounds(9, 20, 372, 13);
                textBox.SetBounds(12, 36, 372, 20);
                buttonOk.SetBounds(309, 72, 75, 23);

                label.AutoSize = true;
                textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
                buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

                form.ClientSize = new System.Drawing.Size(396, 107);
                form.Controls.AddRange(new Control[] { label, textBox, buttonOk });
                form.ClientSize = new System.Drawing.Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
                form.FormBorderStyle = FormBorderStyle.FixedDialog;
                form.StartPosition = FormStartPosition.CenterScreen;
                form.MinimizeBox = false;
                form.MaximizeBox = false;
                form.AcceptButton = buttonOk;

                DialogResult dialogResult = form.ShowDialog();
                string result = textBox.Text;

                form.Dispose();

                if (dialogResult == DialogResult.OK)
                {
                    return result;
                }

                return null;
            }
        }

        public static void LerInformacoesSalvas()
        {
            if (File.Exists("informacoes.txt"))
            {
                turmas.Clear();
                alunoNotas.Clear();
                alunoTurmas.Clear();
                alunos.Clear(); 
                
                try
                {
                    using (StreamReader reader = new StreamReader("informacoes.txt"))
                    {
                        string line;

                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] parts = line.Split(';');

                            if (parts[0] == "aluno")
                            {
                                string nome = parts[1];
                                DateTime dataNascimento = DateTime.Parse(parts[2]);
                                string cpf = parts[3];
                                string sexo = parts[4];
                                string telefone = parts[5];
                                string matricula = parts[6];

                                Aluno aluno = new Aluno(nome, dataNascimento, cpf, sexo, telefone, matricula);
                                alunos.Add(aluno);
                            }
                            else if (parts[0] == "turma")
                            {
                                string nome = parts[1];
                                string materia = parts[2];

                                Turma turma = new Turma(nome, materia);
                                turmas.Add(turma);
                            }
                            else if (parts[0] == "alunoturma")
                            {
                                string turmaNome = parts[1];
                                string alunoNome = parts[2];

                                AlunoTurma alunoTurma = new AlunoTurma(alunoNome, turmaNome);
                                funcoes.alunoTurmas.Add(alunoTurma);
                            }
                            else if (parts[0] == "alunonota")
                            {

                                AlunoNota alunoNota = new AlunoNota();
                                alunoNota.Aluno = parts[1];
                                alunoNota.Turma = parts[7];
                                alunoNota.Atv1 = double.Parse(parts[2]);
                                alunoNota.Atv2 = double.Parse(parts[3]);
                                alunoNota.Trabalho = double.Parse(parts[4]);
                                alunoNota.Prova1 = double.Parse(parts[5]);
                                alunoNota.Prova2 = double.Parse(parts[6]);

                                funcoes.alunoNotas.Add(alunoNota);
                                
                            }
                        }
                    }

                    Console.WriteLine("Informações carregadas com sucesso!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao ler o arquivo: {ex.Message}");
                }
            }
        }

    }
}
