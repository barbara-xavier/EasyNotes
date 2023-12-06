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
    public partial class frm_Lancar_Notas : Form
    {
        private string aluno;
        private string turma;
        public frm_Lancar_Notas()
        {
            InitializeComponent();
        }
        public frm_Lancar_Notas(string aluno, string turma)
        {
            InitializeComponent();
            this.aluno = aluno;
            label1.Text = "Notas do(a) " + aluno;
            this.turma = turma;
        }



        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            AlunoNota nota = new AlunoNota();
            nota.Aluno = aluno;
            nota.Turma = turma;
            nota.Atv1 = double.Parse(tx_Atv1.Text);
            nota.Atv2 = double.Parse(tx_Atv2.Text);
            nota.Trabalho = double.Parse(tx_Trab.Text);
            nota.Prova1 = double.Parse(tx_prova1.Text);
            nota.Prova2 = double.Parse(tx_prova2.Text);

            funcoes.SalvarInformacoes(nota);
            funcoes.LerInformacoesSalvas();


            this.Close();
        }
    }
}
