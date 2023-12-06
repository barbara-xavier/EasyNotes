using Cadastrar_Aluno_forms.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastrar_Aluno_forms
{
    public partial class frm_Turma : Form
    {
        public frm_Turma()
        {
            InitializeComponent();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Turma salvamentoTurma = new Turma(txNomeTurma.Text, txMateria.Text);
                

                // Gerar o conteúdo do arquivo
                string conteudoArquivo = $"turma;{salvamentoTurma.Nome};{salvamentoTurma.Materia}";

                // Escrever o conteúdo no arquivo
                salvamentoTurma.AdicionarTurma(salvamentoTurma);
                salvamentoTurma.SalvarInformacoesTurma();

                /*
                listaRelatorios.Clear();
                CriarListaRelatorio();
                ObterRelatorio();*/


                MessageBox.Show("Turma criada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao salvar: {ex.Message}");

            }
        }

        private void frm_Turma_Load(object sender, EventArgs e)
        {

        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txNomeTurma_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
