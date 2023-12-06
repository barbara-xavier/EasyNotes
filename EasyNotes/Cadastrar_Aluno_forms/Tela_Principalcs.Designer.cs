namespace Cadastrar_Aluno_forms
{
    partial class frm_Tela_Principalcs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bntCadastrar_Turma = new System.Windows.Forms.Button();
            this.bnt_cadastrar_aluno = new System.Windows.Forms.Button();
            this.bnt_visualizarTurmas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntCadastrar_Turma
            // 
            this.bntCadastrar_Turma.BackColor = System.Drawing.Color.RoyalBlue;
            this.bntCadastrar_Turma.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold);
            this.bntCadastrar_Turma.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bntCadastrar_Turma.Location = new System.Drawing.Point(495, 137);
            this.bntCadastrar_Turma.Name = "bntCadastrar_Turma";
            this.bntCadastrar_Turma.Size = new System.Drawing.Size(316, 106);
            this.bntCadastrar_Turma.TabIndex = 1;
            this.bntCadastrar_Turma.Text = "Cadastrar Turma";
            this.bntCadastrar_Turma.UseVisualStyleBackColor = false;
            this.bntCadastrar_Turma.Click += new System.EventHandler(this.bntCadastrar_Turma_Click);
            // 
            // bnt_cadastrar_aluno
            // 
            this.bnt_cadastrar_aluno.BackColor = System.Drawing.Color.RoyalBlue;
            this.bnt_cadastrar_aluno.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold);
            this.bnt_cadastrar_aluno.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bnt_cadastrar_aluno.Location = new System.Drawing.Point(56, 137);
            this.bnt_cadastrar_aluno.Name = "bnt_cadastrar_aluno";
            this.bnt_cadastrar_aluno.Size = new System.Drawing.Size(316, 106);
            this.bnt_cadastrar_aluno.TabIndex = 2;
            this.bnt_cadastrar_aluno.Text = "Cadastrar Aluno";
            this.bnt_cadastrar_aluno.UseVisualStyleBackColor = false;
            this.bnt_cadastrar_aluno.Click += new System.EventHandler(this.bnt_cadastrar_aluno_Click);
            // 
            // bnt_visualizarTurmas
            // 
            this.bnt_visualizarTurmas.BackColor = System.Drawing.Color.RoyalBlue;
            this.bnt_visualizarTurmas.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold);
            this.bnt_visualizarTurmas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bnt_visualizarTurmas.Location = new System.Drawing.Point(271, 322);
            this.bnt_visualizarTurmas.Name = "bnt_visualizarTurmas";
            this.bnt_visualizarTurmas.Size = new System.Drawing.Size(316, 116);
            this.bnt_visualizarTurmas.TabIndex = 3;
            this.bnt_visualizarTurmas.Text = "Vizualizar turmas";
            this.bnt_visualizarTurmas.UseVisualStyleBackColor = false;
            this.bnt_visualizarTurmas.Click += new System.EventHandler(this.bnt_visualizarTurmas_Click);
            // 
            // frm_Tela_Principalcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 564);
            this.Controls.Add(this.bnt_visualizarTurmas);
            this.Controls.Add(this.bnt_cadastrar_aluno);
            this.Controls.Add(this.bntCadastrar_Turma);
            this.Name = "frm_Tela_Principalcs";
            this.Text = "Tela_Principalcs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntCadastrar_Turma;
        private System.Windows.Forms.Button bnt_cadastrar_aluno;
        private System.Windows.Forms.Button bnt_visualizarTurmas;
    }
}