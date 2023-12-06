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
    public partial class frm_Tela_Principalcs : Form
    {


        public frm_Tela_Principalcs()
        {
            InitializeComponent();
            funcoes.alunos = new List<Aluno>();
            funcoes.turmas = new List<Turma>();
            funcoes.alunoTurmas = new List<AlunoTurma>();

            funcoes.LerInformacoesSalvas();
        }

        private void bnt_cadastrar_aluno_Click(object sender, EventArgs e)
        {
            frm_aluno aluno = new frm_aluno();
            aluno.Show();
        }

        private void bntCadastrar_Turma_Click(object sender, EventArgs e)
        {
            frm_Turma turma = new frm_Turma();
            turma.Show();
        }

        private void bnt_visualizarTurmas_Click(object sender, EventArgs e)
        {
            frm_Vizualizar_Turmas vizualizar = new frm_Vizualizar_Turmas();
            vizualizar.Show();
        }
    }
}
