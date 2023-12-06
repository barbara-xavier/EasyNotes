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
    public partial class frm_Vizualizar_Turmas : Form
    {
        public frm_Vizualizar_Turmas()
        {
            InitializeComponent();
            CriarBotoes();
        }

        private void CriarBotoes()
        {
            // Inicialize a lista de botões das turmas
            List<Button> botoesTurmas = new List<Button>();

            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.Dock = DockStyle.Top;
            panel.FlowDirection = FlowDirection.LeftToRight;
            panel.WrapContents = false;
            

            // Crie e posicione os botões das turmas
            for (int i = 0; i < funcoes.turmas.Count; i++)
            {

                Button botaoTurma = new Button();
                botaoTurma.Text = funcoes.turmas[i].Nome;
                //botaoTurma.Top = 10 + (i * 30); // Posiciona verticalmente
                //botaoTurma.Left = 10; // Posiciona horizontalmente
                botaoTurma.Margin = new Padding(10, 10, 10, 0); // Margem entre os botões
                botaoTurma.Click += BotaoTurma_Click; // Adiciona o evento de clique
                
                botaoTurma.BackColor = System.Drawing.Color.RoyalBlue;
                botaoTurma.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold);
                botaoTurma.ForeColor = System.Drawing.SystemColors.ButtonFace;
                //botaoTurma.Location = new System.Drawing.Point(311, 431);
                botaoTurma.Name = "bt" + funcoes.turmas[i].Nome;
                botaoTurma.Size = new System.Drawing.Size(164, 51); 
                botaoTurma.TabIndex = 15;
                botaoTurma.UseVisualStyleBackColor = false;
                botoesTurmas.Add(botaoTurma); // Adiciona o botão à lista

                
                panel.Controls.Add(botaoTurma);

            }
            pn_botoes.Controls.Add(panel);
           // Controls.Add(panel); // Adiciona o botão ao formulário
        }

        private void BotaoTurma_Click(object sender, EventArgs e)
        {
            Button botaoTurmaClicado = (Button)sender;
            string nomeTurmaClicada = botaoTurmaClicado.Text;

            frm_Turma_Separada frm_turma = new frm_Turma_Separada(nomeTurmaClicada);
            frm_turma.Show();
            // Aqui você pode implementar a lógica para lidar com o clique do botão da turma selecionada
            // Por exemplo, exibir informações da turma, abrir um novo formulário relacionado, etc.

            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frm_Vizualizar_Turmas_Load(object sender, EventArgs e)
        {

        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            //frm_Tela_Principalcs vizualizar = new frm_Tela_Principalcs();
            //vizualizar.Show();
        }
    }
}
