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
    public partial class frm_aluno : Form
    {
        int matricula = 0;
        public frm_aluno()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
               
                matricula = funcoes.alunos.Count() + 1; 
                Aluno aluno = new Aluno(txNome.Text, DateTime.Parse(txNascimento.Text), txCPF.Text, cbSexo.Text, txTelefone.Text, matricula.ToString());
 
                funcoes.SalvarInformacoes(aluno);

                MessageBox.Show("Aluno criado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao salvar: {ex.Message}");
                
            }

            this.Close();

            
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_aluno_Load(object sender, EventArgs e)
        {
            
        }
    }
}
