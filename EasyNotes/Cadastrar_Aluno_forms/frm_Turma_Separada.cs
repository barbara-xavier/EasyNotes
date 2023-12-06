using Cadastrar_Aluno_forms.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastrar_Aluno_forms
{
    public partial class frm_Turma_Separada : Form
    {
        private string nomeTurma;
        List<relatorio> listaRelatorios = new List<relatorio>();
        public frm_Turma_Separada()
        {
            InitializeComponent();
        }
        public frm_Turma_Separada(string turma)
        {
            InitializeComponent();
            label1.Text = turma;
            nomeTurma = turma;
            dataGridView1.AutoGenerateColumns = true;
            CriarListaRelatorio();
        }

        private void CriarListaRelatorio() 
        {
            var listaAlunos = funcoes.alunoTurmas.Where(a => a.Turma.Trim().ToLower() == nomeTurma.Trim().ToLower());
            foreach (var item in listaAlunos)
            {
                var aluno = funcoes.alunos.Find(a => a.Nome == item.Aluno);
                var nota = funcoes.alunoNotas.Find(a => a.Aluno.Trim().ToLower() == item.Aluno.Trim().ToLower() && a.Turma.Trim().ToLower() == item.Turma.Trim().ToLower());
                if (aluno != null)
                {
                    relatorio rel = new relatorio();
                    rel.Nome = aluno.Nome;
                    rel.Matricula = aluno.Matricula;

                    if (nota != null)
                    {
                        rel.Atv1 = nota.Atv1.ToString();
                        rel.Atv2 = nota.Atv2.ToString();
                        rel.Trabalho = nota.Trabalho.ToString();
                        rel.Prova1 = nota.Prova1.ToString();
                        rel.Prova2 = nota.Prova2.ToString();
                        rel.Total = (nota.Atv1 + nota.Atv2 + nota.Trabalho + nota.Prova1 + nota.Prova2).ToString();
                    }


                    listaRelatorios.Add(rel);
                    ObterRelatorio();
                }
            }
            
        }
         private void ObterRelatorio()
        {
            dataGridView1.DataSource = new List<relatorio>();
            dataGridView1.DataSource = listaRelatorios;
            dataGridView1.Refresh();
        }
        
        
        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bnt_notas_Click(object sender, EventArgs e)
        {
            // Verifica se há pelo menos uma linha selecionada
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow linhaSelecionada = dataGridView1.SelectedRows[0]; // Obtém a linha selecionada
                var valorCelula = linhaSelecionada.Cells["Nome"].Value; // Obtém o valor da célula na coluna especificada pelo nome

                if (valorCelula != null)
                {
                    string valor = valorCelula.ToString(); // Converte o valor da célula para uma string, se necessário
                    frm_Lancar_Notas form = new frm_Lancar_Notas(valor, nomeTurma);
                    form.Show();
                    funcoes.LerInformacoesSalvas();
                    //
                    listaRelatorios.Clear();
                    CriarListaRelatorio();
                    ObterRelatorio();
                    //

                    
                }
                else
                {
                    MessageBox.Show("O aluno nao foi selecionado!!");
                }
            }
            else
            {
                MessageBox.Show("O aluno nao foi selecionado!!");
            }



           
        }

        private void bnt_adcAluno_Click(object sender, EventArgs e)
        {
            string matricula = funcoes.InputBox.Show("Digite a matricula do Aluno (exemplo: 01):", "Entrada de dados");
            if (matricula != null)
            {
                // Faça algo com o valor digitado pelo usuário
                var aluno = funcoes.alunos.Find(z => z.Matricula == matricula);
                AlunoTurma alunoturma = new AlunoTurma(aluno.Nome, nomeTurma);
                funcoes.SalvarInformacoes(alunoturma);
                funcoes.LerInformacoesSalvas();
                //
                listaRelatorios.Clear();
                CriarListaRelatorio();
                ObterRelatorio();
                
            }
            else
            {
                // O usuário cancelou a entrada de dados
                Console.WriteLine("Entrada de dados cancelada pelo usuário.");
            }
        }

        private void bnt_excluirAluno_Click(object sender, EventArgs e)
        {
            //RemoverLinha(ObterAluno());
            RemoverLinha(ObterTurmaAluno());
            funcoes.LerInformacoesSalvas();
            //
            listaRelatorios.Clear();
            CriarListaRelatorio();
            ObterRelatorio();
            //
            MessageBox.Show("Aluno excluido com sucesso");
            //this.Close();
        }
        private int ObterAluno()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow linhaSelecionada = dataGridView1.SelectedRows[0]; // Obtém a linha selecionada
                var valorCelula = linhaSelecionada.Cells["Nome"].Value; // Obtém o valor da célula na coluna especificada pelo nome

                if (valorCelula != null)
                {
                    int linha = -1;
                    using (StreamReader reader = new StreamReader("informacoes.txt"))
                    {
                        string line;

                        while ((line = reader.ReadLine()) != null)
                        {
                            linha++;
                            string[] parts = line.Split(';');

                            if (parts[0] == "aluno" && parts[1].Trim().ToLower() == valorCelula.ToString().Trim().ToLower())
                            {
                                break;
                            }
                        }
                    }
                    return linha;

                }
                else
                {
                    MessageBox.Show("O aluno nao foi selecionado!!");
                }
            }
            else
            {
                MessageBox.Show("O aluno nao foi selecionado!!");
            }
            return -1;

            
        }
        private string ObterNomeAluno()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow linhaSelecionada = dataGridView1.SelectedRows[0]; // Obtém a linha selecionada
                var valorCelula = linhaSelecionada.Cells["Nome"].Value; // Obtém o valor da célula na coluna especificada pelo nome

                if (valorCelula != null)
                {
                    
                    return valorCelula.ToString();

                }
                else
                {
                    MessageBox.Show("O aluno nao foi selecionado!!");
                }
            }
            else
            {
                MessageBox.Show("O aluno nao foi selecionado!!");
            }
            return "";


        }

        private int ObterTurma()
        {
            int linha = -1;
            using (StreamReader reader = new StreamReader("informacoes.txt"))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    linha++;
                    string[] parts = line.Split(';');

                    if (parts[0] == "turma" && parts[1] == nomeTurma)
                    {
                        break;  
                    }
                }
            }
            return linha;
        }

        private int ObterTurmaAluno()
        {
            int linha = -1;
            bool encontrou = false;
            string nomealuno = ObterNomeAluno();
            using (StreamReader reader = new StreamReader("informacoes.txt"))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    linha++;
                    string[] parts = line.Split(';');

                    if (parts[0] == "alunoturma" && parts[1] == nomeTurma.Trim().ToLower().ToString() && parts[2] == nomealuno)
                    {
                        encontrou = true;
                        break;
                    }
                }
            }
            if (encontrou)
              return linha;
            else
                return -1;
        }

        private void RemoverLinha(int linha)
        {
            string arquivo = "informacoes.txt"; 

            // Lê todas as linhas do arquivo
            string[] linhas = File.ReadAllLines(arquivo);

            int linhaParaRemover = linha;

            if (linhaParaRemover >= 0 && linhaParaRemover < linhas.Length)
            {
                // Remove a linha desejada
                List<string> linhasAtualizadas = new List<string>(linhas);
                linhasAtualizadas.RemoveAt(linhaParaRemover);

                // Escreve o conteúdo atualizado de volta para o arquivo
                File.WriteAllLines(arquivo, linhasAtualizadas);
            }

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            RemoverLinha(ObterTurma());
            
            int linha = 10;

            while( linha > 0)
            {
                linha = ObterTurmaAluno();
                RemoverLinha(linha);
            }

            funcoes.LerInformacoesSalvas();
            //
            listaRelatorios.Clear();
            CriarListaRelatorio();
            ObterRelatorio();
            //
            MessageBox.Show("Turma excluida com sucesso!!!");
            this.Close();
               
          
        }

        public void OrdenarAlunosPorNome()
        {
            listaRelatorios.Sort((at1, at2) => at1.Nome.CompareTo(at2.Nome));
        }

        private void bnt_ordenar_Click(object sender, EventArgs e)
        {
            OrdenarAlunosPorNome();
            dataGridView1.DataSource = new List<relatorio>();
            dataGridView1.DataSource = listaRelatorios;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
